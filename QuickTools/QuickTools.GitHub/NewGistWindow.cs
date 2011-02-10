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
    public partial class NewGistWindow : Form
    {

        public string Title
        {
            get { return _titleTextBox.Text; }
        }

        public string Code
        {
            get { return _codeTextBox.Text; }
        }

        public string Description
        {
            get { return _descriptionTextBox.Text; }
        }

        private Options _options;

        public NewGistWindow()
        {
            InitializeComponent();
        }

        public NewGistWindow(Options options)
            : this()
        {
            _options = options;
            if (_options.DefaultPublic)
                this.AcceptButton = _publicButton;
            else
                this.AcceptButton = _privateButton;
        }

        private void ValidateText(object sender, EventArgs e)
        {
            _privateButton.Enabled = _publicButton.Enabled =
                !(string.IsNullOrEmpty(_titleTextBox.Text)) &&
                !(string.IsNullOrEmpty(_codeTextBox.Text));
        }
    }
}
