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
    /// A verb that converts to HTML.
    /// </summary>
    [Export(typeof(ToHtmlVerb))]
    public class ToHtmlVerb : VerbBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToHtmlVerb"/> class.
        /// </summary>
        public ToHtmlVerb()
            : base("HTML.ToHtml", "To HTML")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            Clipboard.SetText(HttpUtility.HtmlEncode(Clipboard.GetText()));
        }
    }
}
