namespace satis
{
    partial class frmMüşteriListeleme
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
            dataGridView1 = new DataGridView();
            btnGüncelle = new Button();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdsoyad = new TextBox();
            txtTC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSil = new Button();
            txtTcAra = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(455, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(88, 235);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(87, 37);
            btnGüncelle.TabIndex = 21;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(88, 163);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(141, 23);
            txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(88, 134);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(141, 23);
            txtTelefon.TabIndex = 18;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(88, 105);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(141, 23);
            txtAdsoyad.TabIndex = 17;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(88, 76);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(141, 23);
            txtTC.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 200);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 15;
            label5.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 171);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 14;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 142);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 113);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 11;
            label1.Text = "TC";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(88, 296);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(87, 37);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(350, 10);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(100, 23);
            txtTcAra.TabIndex = 23;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 18);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 24;
            label6.Text = "TC ara";
            // 
            // frmMüşteriListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdsoyad);
            Controls.Add(txtTC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdsoyad;
        private TextBox txtTC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private TextBox txtTcAra;
        private Label label6;
    }
}