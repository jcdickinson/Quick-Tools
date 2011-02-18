using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.ComponentModel.Composition;

namespace QuickTools.JonathanD
{
    /// <summary>
    /// Represents the security root verb.
    /// </summary>
    [RootVerbExport]
    public class SecurityRootVerb : VerbBase
    {
        [Import(typeof(BasicAuthenticationHeaderVerb))]
        private BasicAuthenticationHeaderVerb _headerVerb;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRootVerb"/> class.
        /// </summary>
        public SecurityRootVerb()
            : base("Security", "Security")
        {

        }

        public override void Execute()
        {

        }

        /// <summary>
        /// Called when when parts are imported.
        /// </summary>
        protected override void OnPartsImported()
        {
            AddVerbs(_headerVerb);
        }
    }
}
