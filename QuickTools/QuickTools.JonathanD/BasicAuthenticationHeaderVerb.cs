using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.Windows.Forms;
using System.ComponentModel.Composition;

namespace QuickTools.JonathanD
{
    /// <summary>
    /// Creates basic auth tokens.
    /// </summary>
    [Export(typeof(BasicAuthenticationHeaderVerb))]
    public class BasicAuthenticationHeaderVerb : VerbBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthenticationHeaderVerb"/> class.
        /// </summary>
        public BasicAuthenticationHeaderVerb()
            :base("Security.BasicAuth", "Generate Basic Auth Token")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            using (var wind = new BasicAuthenticationWindow())
            {
                var state = wind.ShowDialog();
                if (state == System.Windows.Forms.DialogResult.OK) // Public
                {
                    var token = string.Format("{0}:{1}", wind.Username, wind.Password);
                    token = Convert.ToBase64String(Encoding.ASCII.GetBytes(token));
                    Clipboard.SetText(string.Format("Basic {0}", token));
                }
            }
        }
    }
}
