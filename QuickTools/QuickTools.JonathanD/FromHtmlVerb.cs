using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.Windows.Forms;
using System.Web;
using System.ComponentModel.Composition;

namespace QuickTools.JonathanD
{
    /// <summary>
    /// A verb that converts from HTML.
    /// </summary>
    [Export(typeof(FromHtmlVerb))]
    public class FromHtmlVerb : VerbBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FromHtmlVerb"/> class.
        /// </summary>
        public FromHtmlVerb()
            : base("HTML.FromHtml", "From HTML")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            Clipboard.SetText(HttpUtility.HtmlDecode(Clipboard.GetText()));
        }
    }
}
