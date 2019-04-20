namespace NFilesManager.Code.Interfaces
{
    partial class FScan
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
            this.TextBoxSanPath = new System.Windows.Forms.TextBox();
            this.LScanPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxSanPath
            // 
            this.TextBoxSanPath.Location = new System.Drawing.Point(15, 25);
            this.TextBoxSanPath.Name = "TextBoxSanPath";
            this.TextBoxSanPath.ReadOnly = true;
            this.TextBoxSanPath.Size = new System.Drawing.Size(437, 20);
            this.TextBoxSanPath.TabIndex = 0;
            // 
            // LScanPath
            // 
            this.LScanPath.AutoSize = true;
            this.LScanPath.Location = new System.Drawing.Point(12, 9);
            this.LScanPath.Name = "LScanPath";
            this.LScanPath.Size = new System.Drawing.Size(109, 13);
            this.LScanPath.TabIndex = 1;
            this.LScanPath.Text = "Путь сканирования:";
            // 
            // FScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.LScanPath);
            this.Controls.Add(this.TextBoxSanPath);
            this.Name = "FScan";
            this.Text = "FScan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSanPath;
        private System.Windows.Forms.Label LScanPath;
    }
}