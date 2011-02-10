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
    public partial class FadeWindow : Form
    {
        public FadeWindow()
        {
            InitializeComponent();
        }

        public FadeWindow(string title, string text)
            :this()
        {
            Text = title;
            label1.Text = text;
        }

        private void _fadeTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.015;
            if (this.Opacity < 0.05)
            {
                CloseMe();
            }
        }

        private void CloseMe()
        {
            _fadeTimer.Enabled = false;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CloseMe();
        }
    }
}
