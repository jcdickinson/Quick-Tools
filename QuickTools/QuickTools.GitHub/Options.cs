using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace QuickTools.GitHub
{
    /// <summary>
    /// The github options.
    /// </summary>
    [Export(typeof(Options))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class Options : IDisposable
    {
        private RegistryKey _registryKey;
        [Import(typeof(ApplicationContext))]
        private ApplicationContext _context;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username
        {
            get
            {
                return (string)_registryKey.GetValue("Username", (string)null);
            }
            set
            {
                _registryKey.SetValue("Username", value);
            }
        }
        
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get
            {
                return (string)_registryKey.GetValue("Password", (string)null);
            }
            set
            {
                _registryKey.SetValue("Password", value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether gists should be public by default.
        /// </summary>
        /// <value>
        /// 	<see langword="true"/> if gists should be public by default; otherwise, <see langword="false"/>.
        /// </value>
        public bool DefaultPublic
        {
            get
            {
                return (int)_registryKey.GetValue("Public", 1) != 0;
            }
            set
            {
                _registryKey.SetValue("Public", value ? 1 : 0);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options"/> class.
        /// </summary>
        public Options()
        {
            _registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\JCDickinson\\QuickTools\\GitHub", RegistryKeyPermissionCheck.ReadWriteSubTree);
        }

        /// <summary>
        /// Ensures that settings have been set up.
        /// </summary>
        public bool Ping()
        {
            if(string.IsNullOrEmpty(Username))
            {
                using (var wind = new OptionsWindow(this))
                {
                    _context.MainForm = wind;
                    return wind.ShowDialog() == System.Windows.Forms.DialogResult.OK;
                }
            }
            return true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if(_registryKey != null)
            {
                _registryKey.Dispose();
                _registryKey = null;
            }
        }
    }
}
