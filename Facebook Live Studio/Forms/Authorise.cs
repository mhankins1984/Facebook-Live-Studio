using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Facebook;

namespace Facebook_Live_Studio.Forms

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

        public string PageId
        {
            get
            {
                return ConfigurationManager.AppSettings["PageId"];
            }
        }

        public string UserAccessToken { get; set; }
        public static string PageAccessToken { get; set; }


        private void LoadAuthorise(object sender, EventArgs e)
        //
        // request user access token
        //
        {
            var destinationURL = String.Format(
                @"https://www.facebook.com/v2.8/dialog/oauth?client_id={0}&scope={1}&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token",
                this.ApplicationId,
                this.ExtendedPermissions);
            webBrowser.Navigated += WebBrowserNavigated;
            webBrowser.Navigate(destinationURL);
        }

        private void WebBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        //
        // get user access token from URL
        //
        {
            var url = e.Url.Fragment;
            if (url.Contains("access_token") && url.Contains("#"))
            {
                //
                // get page access token
                //
                this.Close();
                url = (new Regex("#")).Replace(url, "?", 1);
                UserAccessToken = System.Web.HttpUtility.ParseQueryString(url).Get("access_token");

                var fbpat = new FacebookClient(UserAccessToken);
                var GetPageAccessToken = string.Format(
                    @"{0}?fields=access_token",
                    this.PageId);
                dynamic token = fbpat.Get(GetPageAccessToken);
                PageAccessToken = token.access_token;

                try
                {

                }
                catch (Exception exception)
                {
                    Console.Write(exception);
                }
            }

        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}