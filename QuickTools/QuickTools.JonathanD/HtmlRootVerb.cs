using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.ComponentModel.Composition;

namespace QuickTools.JonathanD
{
    /// <summary>
    /// Represents the HTML root verb.
    /// </summary>
    [RootVerbExport]
    public class HtmlRootVerb : VerbBase
    {
        /// <summary>
        /// Gets a value indicating whether this instance can execute.
        /// </summary>
        /// <value>
        /// 	<see langword="true"/> if this instance can execute; otherwise, <see langword="false"/>.
        /// </value>
        public override bool CanExecute
        {
            get
            {
                return false;
            }
        }

        [Import(typeof(FromHtmlVerb))]
        private FromHtmlVerb _fromHtmlVerb;
        [Import(typeof(ToHtmlVerb))]
        private ToHtmlVerb _toHtmlVerb;

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRootVerb"/> class.
        /// </summary>
        public HtmlRootVerb()
            : base("Menu.Html", "HTML")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {

        }

        /// <summary>
        /// Called when when parts are imported.
        /// </summary>
        protected override void OnPartsImported()
        {
            AddVerbs(_fromHtmlVerb, _toHtmlVerb);
        }
    }
}
