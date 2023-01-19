namespace WebScraping.WindowsForms
{
    partial class WebScrapingWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadBtn = new System.Windows.Forms.Button();
            this.InvalidCpfCount = new System.Windows.Forms.Label();
            this.dataTableView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(549, 12);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // InvalidCpfCount
            // 
            this.InvalidCpfCount.AutoSize = true;
            this.InvalidCpfCount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InvalidCpfCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InvalidCpfCount.Location = new System.Drawing.Point(12, 12);
            this.InvalidCpfCount.Name = "InvalidCpfCount";
            this.InvalidCpfCount.Size = new System.Drawing.Size(92, 15);
            this.InvalidCpfCount.TabIndex = 1;
            this.InvalidCpfCount.Text = "0 CPFs Inválidos";
            // 
            // dataTableView
            // 
            this.dataTableView.AllowUserToOrderColumns = true;
            this.dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableView.Location = new System.Drawing.Point(12, 41);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.RowTemplate.Height = 25;
            this.dataTableView.Size = new System.Drawing.Size(612, 397);
            this.dataTableView.TabIndex = 2;
            // 
            // WebScrapingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.dataTableView);
            this.Controls.Add(this.InvalidCpfCount);
            this.Controls.Add(this.UploadBtn);
            this.Name = "WebScrapingWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UploadBtn;
        private Label InvalidCpfCount;
        private DataGridView dataTableView;
    }
}