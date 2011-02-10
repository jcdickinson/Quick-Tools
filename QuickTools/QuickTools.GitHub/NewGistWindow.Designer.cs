namespace QuickTools.GitHub
{
    partial class NewGistWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cancelButton = new System.Windows.Forms.Button();
            this._privateButton = new System.Windows.Forms.Button();
            this._publicButton = new System.Windows.Forms.Button();
            this._codeTextBox = new System.Windows.Forms.TextBox();
            this._titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(438, 284);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 7;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _privateButton
            // 
            this._privateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._privateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._privateButton.Enabled = false;
            this._privateButton.Location = new System.Drawing.Point(357, 284);
            this._privateButton.Name = "_privateButton";
            this._privateButton.Size = new System.Drawing.Size(75, 23);
            this._privateButton.TabIndex = 6;
            this._privateButton.Text = "&Private";
            this._privateButton.UseVisualStyleBackColor = true;
            // 
            // _publicButton
            // 
            this._publicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._publicButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this._publicButton.Enabled = false;
            this._publicButton.Location = new System.Drawing.Point(276, 284);
            this._publicButton.Name = "_publicButton";
            this._publicButton.Size = new System.Drawing.Size(75, 23);
            this._publicButton.TabIndex = 5;
            this._publicButton.Text = "&Public";
            this._publicButton.UseVisualStyleBackColor = true;
            // 
            // _codeTextBox
            // 
            this._codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._codeTextBox.Location = new System.Drawing.Point(12, 69);
            this._codeTextBox.Multiline = true;
            this._codeTextBox.Name = "_codeTextBox";
            this._codeTextBox.Size = new System.Drawing.Size(501, 209);
            this._codeTextBox.TabIndex = 2;
            this._codeTextBox.TextChanged += new System.EventHandler(this.ValidateText);
            // 
            // _titleTextBox
            // 
            this._titleTextBox.Location = new System.Drawing.Point(81, 43);
            this._titleTextBox.Name = "_titleTextBox";
            this._titleTextBox.Size = new System.Drawing.Size(432, 20);
            this._titleTextBox.TabIndex = 1;
            this._titleTextBox.TextChanged += new System.EventHandler(this.ValidateText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // _descriptionTextBox
            // 
            this._descriptionTextBox.Location = new System.Drawing.Point(81, 13);
            this._descriptionTextBox.Name = "_descriptionTextBox";
            this._descriptionTextBox.Size = new System.Drawing.Size(432, 20);
            this._descriptionTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // NewGistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._descriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._titleTextBox);
            this.Controls.Add(this._codeTextBox);
            this.Controls.Add(this._publicButton);
            this.Controls.Add(this._privateButton);
            this.Controls.Add(this._cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGistWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Gist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _privateButton;
        private System.Windows.Forms.Button _publicButton;
        private System.Windows.Forms.TextBox _codeTextBox;
        private System.Windows.Forms.TextBox _titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _descriptionTextBox;
        private System.Windows.Forms.Label label2;
    }
}