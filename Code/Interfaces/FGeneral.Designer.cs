namespace NFilesManager.Code.Interfaces
{
    partial class FGeneral
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
            this.ButtonScanFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonScanFolder
            // 
            this.ButtonScanFolder.Location = new System.Drawing.Point(12, 12);
            this.ButtonScanFolder.Name = "ButtonScanFolder";
            this.ButtonScanFolder.Size = new System.Drawing.Size(122, 23);
            this.ButtonScanFolder.TabIndex = 0;
            this.ButtonScanFolder.Text = "Сканировать";
            this.ButtonScanFolder.UseVisualStyleBackColor = true;
            this.ButtonScanFolder.Click += new System.EventHandler(this.StartScan);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 256);
            this.Controls.Add(this.ButtonScanFolder);
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файловый менеджер";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonScanFolder;
    }
}