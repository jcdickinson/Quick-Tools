using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickTools.JonathanD
{
    public partial class BasicAuthenticationWindow : Form
    {
        public string Username
        {
            get
            {
                return _usernameTextBox.Text;
            }
        }

        public string Password
        {
            get
            {
                return _passwordTextBox.Text;
            }
        }

        public BasicAuthenticationWindow()
        {
            InitializeComponent();
            _usernameTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            _usernameTextBox.Focus();
            _usernameTextBox.SelectAll();
        }
    }
}
