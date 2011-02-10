using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickTools.GitHub
{
    public partial class OptionsWindow : Form
    {
        private Options _options;

        public OptionsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsWindow"/> class.
        /// </summary>
        public OptionsWindow(Options options)
            : this()
        {
            _options = options;
            _usernameTextBox.Text = _options.Username;
            _passwordTextBox.Text = _options.Password;
            _publicCheckBox.Checked = _options.DefaultPublic;
        }

        private void ValidateText(object sender, EventArgs e)
        {
            _okButton.Enabled =
                !string.IsNullOrEmpty(_usernameTextBox.Text) &&
                !string.IsNullOrEmpty(_passwordTextBox.Text);
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            _options.Username = _usernameTextBox.Text;
            _options.Password = _passwordTextBox.Text;
            _options.DefaultPublic = _publicCheckBox.Checked;
        }
    }
}
