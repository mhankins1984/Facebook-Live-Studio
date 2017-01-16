using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Live_Studio.Forms

{
    public partial class Authorise : Form
    {
        public Authorise()
        {
            InitializeComponent();
        }

        public string ApplicationId
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationId"];
            }
        }

        public string ExtendedPermissions
        {
            get
            {
                return ConfigurationManager.AppSettings["ExtendedPermissions"];
            }
        }

        public string AppSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationSecret"];
            }
        }

        public static string UserAccessToken { get; set; }

        private void LoadAuthorise(object sender, EventArgs e)
        {
            var destinationURL = String.Format(
                @"https://www.facebook.com/v2.8/dialog/oauth?client_id={0}&scope={1}&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token",
                this.ApplicationId,
                this.ExtendedPermissions);
            webBrowser.Navigated += WebBrowserNavigated;
            webBrowser.Navigate(destinationURL);
        }

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var url = e.Url.Fragment;
            if (url.Contains("access_token") && url.Contains("#"))
            {
                this.Close();
                url = (new Regex("#")).Replace(url, "?", 1);
                UserAccessToken = System.Web.HttpUtility.ParseQueryString(url).Get("access_token");
            }
        }
    }
}