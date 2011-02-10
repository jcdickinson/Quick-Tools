using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.Windows.Forms;

namespace QuickTools.JonathanD
{
    [RootVerbExport]
    public class CreateGuidRootVerb : VerbBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuidRootVerb"/> class.
        /// </summary>
        public CreateGuidRootVerb()
            : base("Create.Guid", "Create new GUID")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            Clipboard.SetText(Guid.NewGuid().ToString());
        }
    }
}
