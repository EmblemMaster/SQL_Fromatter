namespace SQL_Fromatter
{
    partial class SQL_Formatter
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
            this.pnl_dropArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_files = new System.Windows.Forms.ListBox();
            this.btn_formatSQL = new System.Windows.Forms.Button();
            this.btn_removeFile = new System.Windows.Forms.Button();
            this.pnl_dropArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_dropArea
            // 
            this.pnl_dropArea.AllowDrop = true;
            this.pnl_dropArea.Controls.Add(this.label1);
            this.pnl_dropArea.Location = new System.Drawing.Point(12, 12);
            this.pnl_dropArea.Name = "pnl_dropArea";
            this.pnl_dropArea.Size = new System.Drawing.Size(260, 75);
            this.pnl_dropArea.TabIndex = 0;
            this.pnl_dropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnl_dropArea_DragDrop);
            this.pnl_dropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnl_dropArea_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag and Drop SQL Files Here";
            // 
            // lst_files
            // 
            this.lst_files.FormattingEnabled = true;
            this.lst_files.Location = new System.Drawing.Point(12, 93);
            this.lst_files.Name = "lst_files";
            this.lst_files.Size = new System.Drawing.Size(260, 355);
            this.lst_files.TabIndex = 1;
            // 
            // btn_formatSQL
            // 
            this.btn_formatSQL.Location = new System.Drawing.Point(12, 454);
            this.btn_formatSQL.Name = "btn_formatSQL";
            this.btn_formatSQL.Size = new System.Drawing.Size(193, 45);
            this.btn_formatSQL.TabIndex = 2;
            this.btn_formatSQL.Text = "Format SQL";
            this.btn_formatSQL.UseVisualStyleBackColor = true;
            this.btn_formatSQL.Click += new System.EventHandler(this.btn_formatSQL_Click);
            // 
            // btn_removeFile
            // 
            this.btn_removeFile.Location = new System.Drawing.Point(211, 454);
            this.btn_removeFile.Name = "btn_removeFile";
            this.btn_removeFile.Size = new System.Drawing.Size(61, 45);
            this.btn_removeFile.TabIndex = 3;
            this.btn_removeFile.Text = "Remove File";
            this.btn_removeFile.UseVisualStyleBackColor = true;
            this.btn_removeFile.Click += new System.EventHandler(this.btn_removeFile_Click);
            // 
            // SQL_Formatter
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(284, 511);
            this.Controls.Add(this.btn_removeFile);
            this.Controls.Add(this.btn_formatSQL);
            this.Controls.Add(this.lst_files);
            this.Controls.Add(this.pnl_dropArea);
            this.Name = "SQL_Formatter";
            this.Text = "SQL Formatter";
            this.pnl_dropArea.ResumeLayout(false);
            this.pnl_dropArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_dropArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_files;
        private System.Windows.Forms.Button btn_formatSQL;
        private System.Windows.Forms.Button btn_removeFile;
    }
}

