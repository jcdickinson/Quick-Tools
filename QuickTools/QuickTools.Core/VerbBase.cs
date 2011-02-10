using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace QuickTools.Core
{
    /// <summary>
    /// Represents the default implementation of a verb.
    /// </summary>
    public abstract class VerbBase : IVerb, IPartImportsSatisfiedNotification
    {
        private List<IVerb> _verbs = new List<IVerb>();

        /// <summary>
        /// Gets the title for the verb.
        /// </summary>
        public string Title
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the name of the verb.
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value indicating whether this instance can execute.
        /// </summary>
        /// <value>
        /// 	<see langword="true"/> if this instance can execute; otherwise, <see langword="false"/>.
        /// </value>
        public virtual bool CanExecute
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerbBase"/> class.
        /// </summary>
        public VerbBase(string name, string title)
        {
            Name = name;
            Title = title;
        }

        /// <summary>
        /// Executes the verb.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Adds the specified verbs.
        /// </summary>
        /// <param name="verbs">The verbs.</param>
        protected void AddVerbs(IEnumerable<IVerb> verbs)
        {
            _verbs.AddRange(verbs);
        }

        /// <summary>
        /// Adds the specified verbs.
        /// </summary>
        /// <param name="verbs">The verbs.</param>
        protected void AddVerbs(params IVerb[] verbs)
        {
            _verbs.AddRange(verbs);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"></see> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<IVerb> GetEnumerator()
        {
            return _verbs.GetEnumerator();
        }

        /// <summary>
        /// Called when when parts are imported.
        /// </summary>
        protected virtual void OnPartsImported()
        {

        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Called when a part's imports have been satisfied and it is safe to use.
        /// </summary>
        void IPartImportsSatisfiedNotification.OnImportsSatisfied()
        {
            _verbs.Clear();
            OnPartsImported();
        }
    }
}
