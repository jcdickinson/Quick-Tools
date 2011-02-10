using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickTools.Core;
using System.ComponentModel.Composition;

namespace QuickTools.GitHub
{
    /// <summary>
    /// The options verb.
    /// </summary>
    [Export(typeof(OptionsGistVerb))]
    public class OptionsGistVerb : VerbBase
    {
        [Import(typeof(Options))]
        private Options _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsGistVerb"/> class.
        /// </summary>
        public OptionsGistVerb()
            : base("GitHub.Options", "Options")
        {

        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public override void Execute()
        {
            using (var wind = new OptionsWindow(_options))
            {
                wind.ShowDialog();
            }
        }
    }
}
