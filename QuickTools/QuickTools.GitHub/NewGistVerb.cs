using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.ComponentModel.Composition;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace QuickTools.GitHub
{
    /// <summary>
    /// Represents the New Gist verb.
    /// </summary>
    [Export(typeof(NewGistVerb))]
    public class NewGistVerb : VerbBase
    {
        [Import(typeof(Options))]
        private Options _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewGistVerb"/> class.
        /// </summary>
        public NewGistVerb()
            : base("GitHub.NewGist", "New Gist")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            if (!_options.Ping())
                return;
            using (var wind = new NewGistWindow(_options))
            {
                var state = wind.ShowDialog();
                if (state == System.Windows.Forms.DialogResult.Yes) // Public
                    CreateGist(true, wind.Title, wind.Description, wind.Code);
            }
        }

        private void CreateGist(bool isPublic, string title, string description, string code)
        {
            var wr = WebRequest.Create("https://gist.github.com/api/v1/xml/new");
            wr.PreAuthenticate = true;
            wr.ContentType = "application/x-www-form-urlencoded";
            wr.Method = "POST";
            if (wr.Proxy != null)
                wr.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;

            wr.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(
                string.Format("{0}:{1}", _options.Username, _options.Password)
                )));

            var formData = new StringBuilder();
            formData.AppendFormat("files[{0}]=", Uri.EscapeDataString(title));
            formData.Append(Uri.EscapeDataString(code));

            if (!string.IsNullOrEmpty("description"))
            {
                formData.AppendFormat("&action_button={0}", Uri.EscapeDataString(description));
            }
            if (!isPublic)
            {
                formData.Append("&action_button=private");
            }

            try
            {
                var data = Encoding.ASCII.GetBytes(formData.ToString());
                wr.ContentLength = data.Length;

                using (var stream = wr.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                using (var resp = wr.GetResponse())
                {
                    using (var strm = resp.GetResponseStream())
                    {
                        var xml = XDocument.Load(strm);

                        var repo = xml.Elements("gists").Elements("gist").Elements("repo").Select(x => x.Value).FirstOrDefault();
                        var url = string.Format("https://gist.github.com/{0}", repo);
                        Clipboard.SetText(url);

                        using(var wind = new FadeWindow("Gist Saved", string.Format("Gist {0} saved. URL is in clipboard.", repo)))
                            wind.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Saving Gist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
