using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickTools.Core
{
    /// <summary>
    /// Represents a verb.
    /// </summary>
    public interface IVerb : IEnumerable<IVerb>
    {
        /// <summary>
        /// Gets the title for the verb.
        /// </summary>
        string Title
        {
            get;
        }

        /// <summary>
        /// Gets the name of the verb.
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance can execute.
        /// </summary>
        /// <value>
        /// 	<see langword="true"/> if this instance can execute; otherwise, <see langword="false"/>.
        /// </value>
        bool CanExecute
        {
            get;
        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        void Execute();
    }
}
