using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChromeExtensionIdentifier
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            List<string> cleaned = new List<string>();

            string[] subs = tbInput.Text.Split('\n');
            foreach (var sub in subs)
            {
                cleaned.Add(sub.Trim('\r', ' '));
            }

            string tnaddress = "https://chrome.google.com/webstore/detail/";

            //added for SSL support
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            dataOutput.Rows.Clear();

            foreach (var id in cleaned)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    List<string> row = new List<string>();
                    string result = "";
                    string descr = "";
                    string link = "";

                    try
                    {
                        WebClient wcl = new WebClient();
                        ConfigureWebClient(wcl);

                        string address = tnaddress + id;
                        string response = wcl.DownloadString(address);

                        //Get all HTML metatag values
                        Regex metaTag = new Regex("<meta property=\"(.+?)\" content=\"(.+?)\">");
                        Dictionary<string, string> metaInformation = new Dictionary<string, string>();
                        foreach (Match m in metaTag.Matches(response))
                        {
                            metaInformation.Add(m.Groups[1].Value, m.Groups[2].Value);
                        }

                        if (metaInformation.ContainsKey("og:title"))
                        {
                            result = metaInformation["og:title"];
                        }

                        if (metaInformation.ContainsKey("og:description"))
                        {
                            descr = metaInformation["og:description"];
                        }

                        if (metaInformation.ContainsKey("og:url"))
                        {
                            link = metaInformation["og:url"];
                        }
                    }
                    catch (WebException webexc)
                    {
                        WebExceptionStatus status = webexc.Status;

                        switch (status)
                        {
                            case WebExceptionStatus.ProtocolError:
                                result = "No details found.";

                                break;

                            default:
                                result = "Error occured: " + webexc.Message;

                                break;
                        }
                    }

                    row.Add(result);
                    row.Add(descr);
                    row.Add(link);

                    dataOutput.Rows.Add(row.ToArray());
                }
            }
        }

        private void dataOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    var row = dataOutput.Rows[e.RowIndex];
                    if (row.Cells[2].Value == null) return;
                    var url = row.Cells[2].Value.ToString();
                    System.Diagnostics.Process.Start(url);
                }
            }
            catch
            {
                MessageBox.Show("Storage path error, please check if the path is correct");
            }
        }

        #region Proxy Configuration

        internal static void ConfigureWebClient(WebClient wc)
        {
            try
            {
                if (GetWebProxy(out IWebProxy prx)) wc.Proxy = prx;
            }
            catch (Exception) { Debug.Assert(false); }
        }

        internal static bool GetWebProxy(out IWebProxy prx)
        {
            bool b = GetWebProxyServer(out prx);
            if (b) AssignCredentials(prx);
            return b;
        }

        internal static bool GetWebProxyServer(out IWebProxy prx)
        {
            prx = null;

            try
            {
                prx = WebRequest.GetSystemWebProxy();
                if (prx == null) prx = WebRequest.DefaultWebProxy;

                return (prx != null);
            }
            catch (Exception) { Debug.Assert(false); }

            return false;
        }

        internal static void AssignCredentials(IWebProxy prx)
        {
            if (prx == null) return; // No assert

            try
            {
                prx.Credentials = CredentialCache.DefaultCredentials;
            }
            catch (Exception) { Debug.Assert(false); }
        }

        #endregion Proxy Configuration
    }
}
