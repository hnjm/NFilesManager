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
            this.СheckedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.LListFiles = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.LClient = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonClientInfo = new System.Windows.Forms.Button();
            this.ButtonSendFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxSanPath
            // 
            this.TextBoxSanPath.Location = new System.Drawing.Point(12, 54);
            this.TextBoxSanPath.Name = "TextBoxSanPath";
            this.TextBoxSanPath.ReadOnly = true;
            this.TextBoxSanPath.Size = new System.Drawing.Size(437, 20);
            this.TextBoxSanPath.TabIndex = 0;
            // 
            // LScanPath
            // 
            this.LScanPath.AutoSize = true;
            this.LScanPath.Location = new System.Drawing.Point(9, 38);
            this.LScanPath.Name = "LScanPath";
            this.LScanPath.Size = new System.Drawing.Size(109, 13);
            this.LScanPath.TabIndex = 1;
            this.LScanPath.Text = "Путь сканирования:";
            // 
            // СheckedListBoxFiles
            // 
            this.СheckedListBoxFiles.FormattingEnabled = true;
            this.СheckedListBoxFiles.Location = new System.Drawing.Point(12, 93);
            this.СheckedListBoxFiles.Name = "СheckedListBoxFiles";
            this.СheckedListBoxFiles.Size = new System.Drawing.Size(437, 319);
            this.СheckedListBoxFiles.TabIndex = 2;
            // 
            // ButtonScan
            // 
            this.ButtonScan.Location = new System.Drawing.Point(12, 12);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(82, 23);
            this.ButtonScan.TabIndex = 3;
            this.ButtonScan.Text = "Сканировать";
            this.ButtonScan.UseVisualStyleBackColor = true;
            this.ButtonScan.Click += new System.EventHandler(this.StartScan);
            // 
            // LListFiles
            // 
            this.LListFiles.AutoSize = true;
            this.LListFiles.Location = new System.Drawing.Point(9, 77);
            this.LListFiles.Name = "LListFiles";
            this.LListFiles.Size = new System.Drawing.Size(88, 13);
            this.LListFiles.TabIndex = 4;
            this.LListFiles.Text = "Список файлов:";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(12, 456);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(106, 23);
            this.ButtonConnect.TabIndex = 5;
            this.ButtonConnect.Text = "Выбрать клиента";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ConnectToClient);
            // 
            // LClient
            // 
            this.LClient.AutoSize = true;
            this.LClient.Location = new System.Drawing.Point(9, 414);
            this.LClient.Name = "LClient";
            this.LClient.Size = new System.Drawing.Size(46, 13);
            this.LClient.TabIndex = 7;
            this.LClient.Text = "Клиент:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(406, 20);
            this.textBox1.TabIndex = 6;
            // 
            // ButtonClientInfo
            // 
            this.ButtonClientInfo.Location = new System.Drawing.Point(424, 430);
            this.ButtonClientInfo.Name = "ButtonClientInfo";
            this.ButtonClientInfo.Size = new System.Drawing.Size(25, 20);
            this.ButtonClientInfo.TabIndex = 8;
            this.ButtonClientInfo.Text = "?";
            this.ButtonClientInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonSendFiles
            // 
            this.ButtonSendFiles.Location = new System.Drawing.Point(312, 456);
            this.ButtonSendFiles.Name = "ButtonSendFiles";
            this.ButtonSendFiles.Size = new System.Drawing.Size(106, 23);
            this.ButtonSendFiles.TabIndex = 9;
            this.ButtonSendFiles.Text = "Отправить файлы";
            this.ButtonSendFiles.UseVisualStyleBackColor = true;
            // 
            // FScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 491);
            this.Controls.Add(this.ButtonSendFiles);
            this.Controls.Add(this.ButtonClientInfo);
            this.Controls.Add(this.LClient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LListFiles);
            this.Controls.Add(this.ButtonScan);
            this.Controls.Add(this.СheckedListBoxFiles);
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
        private System.Windows.Forms.CheckedListBox СheckedListBoxFiles;
        private System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.Label LListFiles;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label LClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonClientInfo;
        private System.Windows.Forms.Button ButtonSendFiles;
    }
}