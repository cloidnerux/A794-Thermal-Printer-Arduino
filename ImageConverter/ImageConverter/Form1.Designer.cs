namespace ImageConverter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ImageProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Location = new System.Drawing.Point(13, 13);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(150, 45);
            this.OpenImageButton.TabIndex = 0;
            this.OpenImageButton.Text = "Open Image";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            this.OpenImageButton.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(13, 65);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(408, 270);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            // 
            // ImageProgressBar
            // 
            this.ImageProgressBar.Location = new System.Drawing.Point(199, 23);
            this.ImageProgressBar.Name = "ImageProgressBar";
            this.ImageProgressBar.Size = new System.Drawing.Size(222, 23);
            this.ImageProgressBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 347);
            this.Controls.Add(this.ImageProgressBar);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OpenImageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.ProgressBar ImageProgressBar;
    }
}

