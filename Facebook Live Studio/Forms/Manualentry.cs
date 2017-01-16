using System;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Configuration;

namespace Live_Studio.Forms
{
    public partial class Manualentry : Form
    {
        public Manualentry(DataTable QueTable, DataTable PreviewTable, CheckBox APCheck, DataGridView PreviewDataGridView)
        {
            InitializeComponent();
            this.QueTable = QueTable;
            this.PreviewTable = PreviewTable;
            this.APCheck = APCheck;
            this.PreviewDataGridView = PreviewDataGridView;
        }

        private DataTable QueTable;
        private DataTable PreviewTable;
        private CheckBox APCheck;
        private DataGridView PreviewDataGridView;

        public string ChyronServer
        {
            get
            {
                return ConfigurationManager.AppSettings["ChyronServer"];
            }
        }

        string server;

        void outputXmL(string name, string comment)
        {
            ChyronData cd = new ChyronData();

            cd.PageType = "facebook_template_1";
            cd.TemplatePageNumber = "201";
            cd.BuildPageNumber = "1001";
            cd.Name = name;
            cd.Comment = comment;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(cd.GetType());
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"\\10.176.4.104\ProjectParking\Election2016XML\ConstituencyXML\feedback.xml");
            x.Serialize(sw, cd);
            sw.Close();
        }

        void sendastring(String w)
        {
            Debug.WriteLine(String.Format("Chyron Server : {0}", ChyronServer));
            server = ChyronServer;
            Int32 port = 23;
            TcpClient client = new TcpClient(server, port);
            Debug.WriteLine(String.Format("Chyron Server : {0}", client.Client.RemoteEndPoint));

            NetworkStream stream = client.GetStream();

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(w);
            Debug.WriteLine(data + " Data Length : " + data.Length);

            // Get a client stream for reading and writing.
            Debug.WriteLine(String.Format("Is controlling:{0}, stream read : {1}, write : {2} client connected : {3}", ChyronServer, stream.CanRead, stream.CanWrite, client.Connected));

            // Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length);

            Debug.WriteLine(String.Format("Sent: {0}", w));
            Thread.Sleep(200);
            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            {
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                responseData.Replace("\r\n\r\n", "\r\n");
            }
            // catch { }
            Debug.WriteLine(String.Format("Received: {0}", responseData));

            // Close everything.
            stream.Close();
            client.Close();
        }

        private void Manualentry_Load(object sender, EventArgs e)
        {
            ComBox.MaxLength = 170;
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("A Name must be entered.", "Error");
            }
            else
            {
                if (ComBox.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("A Comment must be entered.", "Error");
                }

                else
                {
                    if (APCheck.Checked == true)
                    {
                        int c2 = PreviewDataGridView.SelectedRows.Count;

                        if (c2 > 0)
                        {
                            QueTable.Rows.Add("Manual Entry", NameBox.Text, ComBox.Text);
                            this.Close();
                        }

                        else
                        {
                            PreviewTable.Rows.Add("Manual Entry", NameBox.Text, ComBox.Text);

                            string name = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                            string comment = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                            outputXmL(name, comment);

                            Thread.Sleep(500);
                            String V5 = @"V\5\13\1\0\feedback strap-auto\1\\" + "\r\n";
                            
                            sendastring(V5);

                            Videocomments.Q2N = PreviewDataGridView.Rows[0].Cells[1].Value.ToString();
                            Videocomments.Q2C = PreviewDataGridView.Rows[0].Cells[2].Value.ToString();

                            this.Close();
                        }
                    }

                    else
                    {
                        QueTable.Rows.Add("Manual Entry", NameBox.Text, ComBox.Text);
                        this.Close();
                    }
                }
            }
        }
    }
}
