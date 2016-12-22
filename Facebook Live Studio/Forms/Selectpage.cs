using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using Newtonsoft.Json;

namespace Facebook_Live_Studio.Forms
{
    public partial class Selectpage : Form
    {
        public Selectpage()
        {
            InitializeComponent();
        }

        //
        //Facebook page classes
        //
        public class Datum
        {
            public string access_token { get; set; }
            public string category { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public IList<string> perms { get; set; }
        }

        public class Cursors
        {
            public string before { get; set; }
            public string after { get; set; }
        }

        public class Paging
        {
            public Cursors cursors { get; set; }
        }

        public class RootObject
        {
            public List<Datum> data { get; set; }
            public Paging paging { get; set; }
        }

        private void PageDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        public static string PageAccessToken { get; set; }
        public static string PageId { get; set; }
        public static string PageTitle { get; set; }

        private void Pageselector_Load(object sender, EventArgs e)
        {
            //
            // PageDataGridView select only one and whole row
            //
            PageDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PageDataGridView.MultiSelect = false;
            PageDataGridView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(PageDataGridView_RowPrePaint);
            //
            // PageDataGridView Autosize
            PageDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //
            // Get page data
            //
            var fb = new FacebookClient(Authorise.UserAccessToken);
            var pages = string.Format(
                @"me/accounts");
            var result = fb.Get(pages);

            string json = result.ToString();
            //
            // Deserialize JSON data
            //
            RootObject rootobject = JsonConvert.DeserializeObject<RootObject>(json);

            int i = 0;

            PageDataGridView.Rows.Clear();
            foreach (Datum d in rootobject.data)
            {
                PageDataGridView.Rows.Add();
                PageDataGridView.Rows[i].Cells[0].Value = d.name;
                PageDataGridView.Rows[i].Cells[1].Value = d.access_token;
                PageDataGridView.Rows[i++].Cells[2].Value = d.id;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            PageTitle = PageDataGridView.SelectedCells[0].Value.ToString();
            PageAccessToken = PageDataGridView.SelectedCells[1].Value.ToString();
            PageId = PageDataGridView.SelectedCells[2].Value.ToString();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
