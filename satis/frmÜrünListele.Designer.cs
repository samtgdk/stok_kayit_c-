namespace satis
{
    partial class frmÜrünListele
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SatisFiyatiTxt = new TextBox();
            BarkodNotxt = new TextBox();
            AlisFiyatiTxt = new TextBox();
            Kategoritxt = new TextBox();
            MiktarTxt = new TextBox();
            MarkaTxt = new TextBox();
            ÜrünAdiTxt = new TextBox();
            btnSil = new Button();
            txtBarkodnoAra = new TextBox();
            label1 = new Label();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGüncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(516, 275);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(93, 328);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(88, 24);
            btnGüncelle.TabIndex = 20;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 288);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 34;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 252);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 33;
            label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 216);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 32;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 180);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 31;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 144);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 30;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 108);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 29;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 72);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 28;
            label14.Text = "Barkod No";
            // 
            // SatisFiyatiTxt
            // 
            SatisFiyatiTxt.Location = new Point(94, 285);
            SatisFiyatiTxt.Name = "SatisFiyatiTxt";
            SatisFiyatiTxt.Size = new Size(101, 23);
            SatisFiyatiTxt.TabIndex = 27;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(93, 69);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(101, 23);
            BarkodNotxt.TabIndex = 21;
            // 
            // AlisFiyatiTxt
            // 
            AlisFiyatiTxt.Location = new Point(94, 251);
            AlisFiyatiTxt.Name = "AlisFiyatiTxt";
            AlisFiyatiTxt.Size = new Size(101, 23);
            AlisFiyatiTxt.TabIndex = 26;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(94, 107);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.ReadOnly = true;
            Kategoritxt.Size = new Size(100, 23);
            Kategoritxt.TabIndex = 22;
            // 
            // MiktarTxt
            // 
            MiktarTxt.Location = new Point(94, 213);
            MiktarTxt.Name = "MiktarTxt";
            MiktarTxt.Size = new Size(101, 23);
            MiktarTxt.TabIndex = 25;
            // 
            // MarkaTxt
            // 
            MarkaTxt.Location = new Point(94, 141);
            MarkaTxt.Name = "MarkaTxt";
            MarkaTxt.ReadOnly = true;
            MarkaTxt.Size = new Size(101, 23);
            MarkaTxt.TabIndex = 23;
            // 
            // ÜrünAdiTxt
            // 
            ÜrünAdiTxt.Location = new Point(94, 177);
            ÜrünAdiTxt.Name = "ÜrünAdiTxt";
            ÜrünAdiTxt.Size = new Size(100, 23);
            ÜrünAdiTxt.TabIndex = 24;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(93, 389);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(88, 24);
            btnSil.TabIndex = 35;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtBarkodnoAra
            // 
            txtBarkodnoAra.Location = new Point(360, 22);
            txtBarkodnoAra.Name = "txtBarkodnoAra";
            txtBarkodnoAra.Size = new Size(163, 23);
            txtBarkodnoAra.TabIndex = 36;
            txtBarkodnoAra.TextChanged += txtBarkodnoAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 37;
            label1.Text = "Barkod No'ya Göre Ara";
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(431, 362);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(121, 23);
            comboKategori.TabIndex = 38;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(431, 391);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(121, 23);
            comboMarka.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 399);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 41;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 363);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 40;
            label3.Text = "Kategori";
            // 
            // btnMarkaGüncelle
            // 
            btnMarkaGüncelle.Location = new Point(581, 363);
            btnMarkaGüncelle.Name = "btnMarkaGüncelle";
            btnMarkaGüncelle.Size = new Size(88, 50);
            btnMarkaGüncelle.TabIndex = 42;
            btnMarkaGüncelle.Text = "Marka Güncelle";
            btnMarkaGüncelle.UseVisualStyleBackColor = true;
            btnMarkaGüncelle.Click += btnMarkaGüncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMarkaGüncelle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(label1);
            Controls.Add(txtBarkodnoAra);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(SatisFiyatiTxt);
            Controls.Add(BarkodNotxt);
            Controls.Add(AlisFiyatiTxt);
            Controls.Add(Kategoritxt);
            Controls.Add(MiktarTxt);
            Controls.Add(MarkaTxt);
            Controls.Add(ÜrünAdiTxt);
            Controls.Add(dataGridView1);
            Name = "frmÜrünListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox SatisFiyatiTxt;
        private TextBox BarkodNotxt;
        private TextBox AlisFiyatiTxt;
        private TextBox Kategoritxt;
        private TextBox MiktarTxt;
        private TextBox MarkaTxt;
        private TextBox ÜrünAdiTxt;
        private Button btnSil;
        private TextBox txtBarkodnoAra;
        private Label label1;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGüncelle;
    }
}