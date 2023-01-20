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
            this.InvalidCount = new System.Windows.Forms.Label();
            this.dataTableView = new System.Windows.Forms.DataGridView();
            this.delimiterTextBox = new System.Windows.Forms.TextBox();
            this.delimiterLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchSiteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomColumnTextBox = new System.Windows.Forms.TextBox();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.CustomRegularExpressionTextBox = new System.Windows.Forms.TextBox();
            this.CnpjVariantTextBox = new System.Windows.Forms.TextBox();
            this.EmailVariantTextBox = new System.Windows.Forms.TextBox();
            this.CpfVariantTextBox = new System.Windows.Forms.TextBox();
            this.PhoneVariantTextBox = new System.Windows.Forms.TextBox();
            this.CnpjCheckbox = new System.Windows.Forms.CheckBox();
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.PhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.CpfCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadBtn.ForeColor = System.Drawing.Color.Cyan;
            this.UploadBtn.Location = new System.Drawing.Point(147, 102);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(135, 39);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // InvalidCount
            // 
            this.InvalidCount.AutoSize = true;
            this.InvalidCount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InvalidCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InvalidCount.Location = new System.Drawing.Point(754, 16);
            this.InvalidCount.Name = "InvalidCount";
            this.InvalidCount.Size = new System.Drawing.Size(92, 15);
            this.InvalidCount.TabIndex = 1;
            this.InvalidCount.Text = "0 CPFs Inválidos";
            // 
            // dataTableView
            // 
            this.dataTableView.AllowUserToOrderColumns = true;
            this.dataTableView.BackgroundColor = System.Drawing.Color.White;
            this.dataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableView.Location = new System.Drawing.Point(9, 51);
            this.dataTableView.Name = "dataTableView";
            this.dataTableView.RowTemplate.Height = 25;
            this.dataTableView.Size = new System.Drawing.Size(736, 384);
            this.dataTableView.TabIndex = 2;
            // 
            // delimiterTextBox
            // 
            this.delimiterTextBox.BackColor = System.Drawing.Color.White;
            this.delimiterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delimiterTextBox.Location = new System.Drawing.Point(6, 22);
            this.delimiterTextBox.MaxLength = 1;
            this.delimiterTextBox.Name = "delimiterTextBox";
            this.delimiterTextBox.Size = new System.Drawing.Size(25, 23);
            this.delimiterTextBox.TabIndex = 3;
            this.delimiterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delimiterLabel
            // 
            this.delimiterLabel.AutoSize = true;
            this.delimiterLabel.Location = new System.Drawing.Point(37, 25);
            this.delimiterLabel.Name = "delimiterLabel";
            this.delimiterLabel.Size = new System.Drawing.Size(250, 15);
            this.delimiterLabel.TabIndex = 4;
            this.delimiterLabel.Text = "Adicione o delimitador do arquivo. Padrão: \";\"\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.downloadBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SearchSiteTextBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.delimiterTextBox);
            this.groupBox1.Controls.Add(this.delimiterLabel);
            this.groupBox1.Controls.Add(this.UploadBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(754, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 397);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções do Editor";
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.ForeColor = System.Drawing.Color.Cyan;
            this.downloadBtn.Location = new System.Drawing.Point(6, 102);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(135, 39);
            this.downloadBtn.TabIndex = 9;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(219, 73);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(64, 23);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Buscar";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Site que terá a tabela resgatada:";
            // 
            // SearchSiteTextBox
            // 
            this.SearchSiteTextBox.BackColor = System.Drawing.Color.White;
            this.SearchSiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchSiteTextBox.Location = new System.Drawing.Point(6, 73);
            this.SearchSiteTextBox.Name = "SearchSiteTextBox";
            this.SearchSiteTextBox.Size = new System.Drawing.Size(207, 23);
            this.SearchSiteTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.ClearBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CustomColumnTextBox);
            this.groupBox2.Controls.Add(this.VerifyBtn);
            this.groupBox2.Controls.Add(this.CustomRegularExpressionTextBox);
            this.groupBox2.Controls.Add(this.CnpjVariantTextBox);
            this.groupBox2.Controls.Add(this.EmailVariantTextBox);
            this.groupBox2.Controls.Add(this.CpfVariantTextBox);
            this.groupBox2.Controls.Add(this.PhoneVariantTextBox);
            this.groupBox2.Controls.Add(this.CnpjCheckbox);
            this.groupBox2.Controls.Add(this.EmailCheckBox);
            this.groupBox2.Controls.Add(this.PhoneCheckBox);
            this.groupBox2.Controls.Add(this.CpfCheckBox);
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verificar";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(202, 112);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(64, 23);
            this.ClearBtn.TabIndex = 20;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Filtro Cutomizado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Expressão Regular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Coluna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Variante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Variante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Variante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Variante";
            // 
            // CustomColumnTextBox
            // 
            this.CustomColumnTextBox.BackColor = System.Drawing.Color.White;
            this.CustomColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomColumnTextBox.Location = new System.Drawing.Point(6, 97);
            this.CustomColumnTextBox.Name = "CustomColumnTextBox";
            this.CustomColumnTextBox.Size = new System.Drawing.Size(72, 23);
            this.CustomColumnTextBox.TabIndex = 14;
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyBtn.Location = new System.Drawing.Point(202, 83);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(64, 23);
            this.VerifyBtn.TabIndex = 10;
            this.VerifyBtn.Text = "Verificar";
            this.VerifyBtn.UseVisualStyleBackColor = false;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // CustomRegularExpressionTextBox
            // 
            this.CustomRegularExpressionTextBox.BackColor = System.Drawing.Color.White;
            this.CustomRegularExpressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomRegularExpressionTextBox.Location = new System.Drawing.Point(84, 97);
            this.CustomRegularExpressionTextBox.Name = "CustomRegularExpressionTextBox";
            this.CustomRegularExpressionTextBox.Size = new System.Drawing.Size(112, 23);
            this.CustomRegularExpressionTextBox.TabIndex = 10;
            // 
            // CnpjVariantTextBox
            // 
            this.CnpjVariantTextBox.BackColor = System.Drawing.Color.White;
            this.CnpjVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CnpjVariantTextBox.Location = new System.Drawing.Point(213, 47);
            this.CnpjVariantTextBox.Name = "CnpjVariantTextBox";
            this.CnpjVariantTextBox.Size = new System.Drawing.Size(53, 23);
            this.CnpjVariantTextBox.TabIndex = 13;
            // 
            // EmailVariantTextBox
            // 
            this.EmailVariantTextBox.BackColor = System.Drawing.Color.White;
            this.EmailVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailVariantTextBox.Location = new System.Drawing.Point(152, 47);
            this.EmailVariantTextBox.Name = "EmailVariantTextBox";
            this.EmailVariantTextBox.Size = new System.Drawing.Size(55, 23);
            this.EmailVariantTextBox.TabIndex = 12;
            // 
            // CpfVariantTextBox
            // 
            this.CpfVariantTextBox.BackColor = System.Drawing.Color.White;
            this.CpfVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpfVariantTextBox.Location = new System.Drawing.Point(11, 47);
            this.CpfVariantTextBox.Name = "CpfVariantTextBox";
            this.CpfVariantTextBox.Size = new System.Drawing.Size(47, 23);
            this.CpfVariantTextBox.TabIndex = 11;
            // 
            // PhoneVariantTextBox
            // 
            this.PhoneVariantTextBox.BackColor = System.Drawing.Color.White;
            this.PhoneVariantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneVariantTextBox.Location = new System.Drawing.Point(70, 47);
            this.PhoneVariantTextBox.Name = "PhoneVariantTextBox";
            this.PhoneVariantTextBox.Size = new System.Drawing.Size(65, 23);
            this.PhoneVariantTextBox.TabIndex = 10;
            // 
            // CnpjCheckbox
            // 
            this.CnpjCheckbox.AutoSize = true;
            this.CnpjCheckbox.Location = new System.Drawing.Point(213, 22);
            this.CnpjCheckbox.Name = "CnpjCheckbox";
            this.CnpjCheckbox.Size = new System.Drawing.Size(53, 19);
            this.CnpjCheckbox.TabIndex = 4;
            this.CnpjCheckbox.Text = "CNPJ";
            this.CnpjCheckbox.UseVisualStyleBackColor = true;
            this.CnpjCheckbox.CheckedChanged += new System.EventHandler(this.CnpjCheckbox_CheckedChanged);
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.AutoSize = true;
            this.EmailCheckBox.Location = new System.Drawing.Point(152, 22);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(55, 19);
            this.EmailCheckBox.TabIndex = 3;
            this.EmailCheckBox.Text = "Email";
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            this.EmailCheckBox.CheckedChanged += new System.EventHandler(this.EmailCheckBox_CheckedChanged);
            // 
            // PhoneCheckBox
            // 
            this.PhoneCheckBox.AutoSize = true;
            this.PhoneCheckBox.Location = new System.Drawing.Point(70, 22);
            this.PhoneCheckBox.Name = "PhoneCheckBox";
            this.PhoneCheckBox.Size = new System.Drawing.Size(71, 19);
            this.PhoneCheckBox.TabIndex = 2;
            this.PhoneCheckBox.Text = "Telefone";
            this.PhoneCheckBox.UseVisualStyleBackColor = true;
            this.PhoneCheckBox.CheckedChanged += new System.EventHandler(this.PhoneCheckBox_CheckedChanged);
            // 
            // CpfCheckBox
            // 
            this.CpfCheckBox.AutoSize = true;
            this.CpfCheckBox.Location = new System.Drawing.Point(11, 22);
            this.CpfCheckBox.Name = "CpfCheckBox";
            this.CpfCheckBox.Size = new System.Drawing.Size(47, 19);
            this.CpfCheckBox.TabIndex = 1;
            this.CpfCheckBox.Text = "CPF";
            this.CpfCheckBox.UseVisualStyleBackColor = true;
            this.CpfCheckBox.CheckedChanged += new System.EventHandler(this.CpfCheckBox_CheckedChanged);
            // 
            // WebScrapingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTableView);
            this.Controls.Add(this.InvalidCount);
            this.Name = "WebScrapingWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UploadBtn;
        private Label InvalidCount;
        private DataGridView dataTableView;
        private TextBox delimiterTextBox;
        private Label delimiterLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button downloadBtn;
        private Button SearchBtn;
        private Label label1;
        private TextBox SearchSiteTextBox;
        private CheckBox CnpjCheckbox;
        private CheckBox EmailCheckBox;
        private CheckBox PhoneCheckBox;
        private CheckBox CpfCheckBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox CustomColumnTextBox;
        private Button VerifyBtn;
        private TextBox CustomRegularExpressionTextBox;
        private TextBox CnpjVariantTextBox;
        private TextBox EmailVariantTextBox;
        private TextBox CpfVariantTextBox;
        private TextBox PhoneVariantTextBox;
        private Label label8;
        private Button ClearBtn;
    }
}