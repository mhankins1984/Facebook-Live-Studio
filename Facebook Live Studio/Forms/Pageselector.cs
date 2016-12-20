using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using Newtonsoft.Json;

namespace Facebook_Live_Studio.Forms
{
    public partial class Pageselector : Form
    {
        public Pageselector()
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

        private void Pageselector_Load(object sender, EventArgs e)
        {
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
                PageDataGridView.Rows[i++].Cells[1].Value = d.access_token;
            }
        }
    }
}
