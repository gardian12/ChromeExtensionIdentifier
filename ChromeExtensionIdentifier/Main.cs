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

            CheckBoxShowID_CheckedChanged(this, EventArgs.Empty);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            List<string> cleaned = new List<string>();

            //allow different separator character
            char[] charSeparators = new char[] { '\n', ',', ';' };
            string[] subs = TextBoxInput.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sub in subs)
            {
                cleaned.Add(sub.Trim('\r', ' '));
            }


            //basic URL of Chrome Web Store
            string tnaddress = "https://chrome.google.com/webstore/detail/";

            //added for SSL support
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;


            //clear output component
            DataOutput.Rows.Clear();

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

                        //get HTML metatag values
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

                    //fill cells per row
                    row.Add(id);
                    row.Add(result);
                    row.Add(descr);
                    row.Add(link);

                    DataOutput.Rows.Add(row.ToArray());
                }
            }
        }

        private void DataOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //start browser when cell with URL was clicked
                if (e.ColumnIndex == this.ColumnLink.DisplayIndex)
                {
                    var row = DataOutput.Rows[e.RowIndex];
                    if (row.Cells[this.ColumnLink.DisplayIndex].Value == null) return;
                    var url = row.Cells[this.ColumnLink.DisplayIndex].Value.ToString();

                    //start browser
                    System.Diagnostics.Process.Start(url);
                }
            }
            catch
            {
                MessageBox.Show("Storage path error, please check if the path is correct");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //clear input component
            TextBoxInput.Clear();
        }
        private void CheckBoxShowID_CheckedChanged(object sender, EventArgs e)
        {
                DataOutput.Columns[this.ColumnID.Name].Visible = CheckBoxShowID.Checked;
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
