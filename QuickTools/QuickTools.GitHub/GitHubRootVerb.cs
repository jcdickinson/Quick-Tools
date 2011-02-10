using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.ComponentModel.Composition;

namespace QuickTools.GitHub
{
    /// <summary>
    /// Represents the GitHub root verb.
    /// </summary>
    [RootVerbExport]
    public class GitHubRootVerb : VerbBase
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

        [Import(typeof(NewGistVerb))]
        private NewGistVerb _newGist;
        [Import(typeof(OptionsGistVerb))]
        private OptionsGistVerb _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubRootVerb"/> class.
        /// </summary>
        public GitHubRootVerb()
            : base("GitHub", "GitHub")
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
            AddVerbs(_newGist, _options);
        }
    }
}
