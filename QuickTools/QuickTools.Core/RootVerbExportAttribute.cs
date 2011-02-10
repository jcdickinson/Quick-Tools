using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace QuickTools.Core
{
    /// <summary>
    /// Represents a root verb export.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
    public sealed class RootVerbExportAttribute : ExportAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootVerbExportAttribute"/> class.
        /// </summary>
        public RootVerbExportAttribute()
            : base(typeof(IVerb))
        {

        }
    }
}
