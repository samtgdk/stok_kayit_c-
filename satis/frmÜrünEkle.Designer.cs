namespace satis
{
    partial class frmÜrünEkle
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnYeniEkle = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            txtSatisFiyati = new TextBox();
            txtAlisFiyati = new TextBox();
            txtMiktar = new TextBox();
            txtÜrünAdi = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            lblMiktar = new Label();
            btnVarOlanaEkle = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboMarka);
            groupBox1.Controls.Add(comboKategori);
            groupBox1.Controls.Add(txtSatisFiyati);
            groupBox1.Controls.Add(txtAlisFiyati);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(txtÜrünAdi);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Location = new Point(30, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 318);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 248);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 12;
            label7.Text = "Satış Fiyatı";
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Location = new Point(95, 288);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(86, 24);
            btnYeniEkle.TabIndex = 2;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 212);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 176);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 140);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 104);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Barkod No";
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(95, 100);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(100, 23);
            comboMarka.TabIndex = 5;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(95, 65);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(100, 23);
            comboKategori.TabIndex = 4;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Location = new Point(95, 240);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(100, 23);
            txtSatisFiyati.TabIndex = 2;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(95, 205);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(100, 23);
            txtAlisFiyati.TabIndex = 3;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(95, 170);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 2;
            // 
            // txtÜrünAdi
            // 
            txtÜrünAdi.Location = new Point(95, 135);
            txtÜrünAdi.Name = "txtÜrünAdi";
            txtÜrünAdi.Size = new Size(100, 23);
            txtÜrünAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(95, 30);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(btnVarOlanaEkle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(SatisFiyatiTxt);
            groupBox2.Controls.Add(BarkodNotxt);
            groupBox2.Controls.Add(AlisFiyatiTxt);
            groupBox2.Controls.Add(Kategoritxt);
            groupBox2.Controls.Add(MiktarTxt);
            groupBox2.Controls.Add(MarkaTxt);
            groupBox2.Controls.Add(ÜrünAdiTxt);
            groupBox2.Location = new Point(268, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 318);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(6, 288);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 15);
            lblMiktar.TabIndex = 20;
            // 
            // btnVarOlanaEkle
            // 
            btnVarOlanaEkle.Location = new Point(84, 288);
            btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            btnVarOlanaEkle.Size = new Size(88, 24);
            btnVarOlanaEkle.TabIndex = 3;
            btnVarOlanaEkle.Text = "Ekle";
            btnVarOlanaEkle.UseVisualStyleBackColor = true;
            btnVarOlanaEkle.Click += btnVarOlanaEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 241);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 19;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 205);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 18;
            label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 169);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 17;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 133);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 16;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 97);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 15;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 61);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 14;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 25);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 13;
            label14.Text = "Barkod No";
            // 
            // SatisFiyatiTxt
            // 
            SatisFiyatiTxt.Location = new Point(85, 238);
            SatisFiyatiTxt.Name = "SatisFiyatiTxt";
            SatisFiyatiTxt.Size = new Size(101, 23);
            SatisFiyatiTxt.TabIndex = 9;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(84, 22);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(101, 23);
            BarkodNotxt.TabIndex = 3;
            BarkodNotxt.TextChanged += BarkodNotxt_TextChanged;
            // 
            // AlisFiyatiTxt
            // 
            AlisFiyatiTxt.Location = new Point(85, 204);
            AlisFiyatiTxt.Name = "AlisFiyatiTxt";
            AlisFiyatiTxt.Size = new Size(101, 23);
            AlisFiyatiTxt.TabIndex = 8;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(85, 60);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.Size = new Size(100, 23);
            Kategoritxt.TabIndex = 4;
            // 
            // MiktarTxt
            // 
            MiktarTxt.Location = new Point(85, 166);
            MiktarTxt.Name = "MiktarTxt";
            MiktarTxt.Size = new Size(101, 23);
            MiktarTxt.TabIndex = 7;
            // 
            // MarkaTxt
            // 
            MarkaTxt.Location = new Point(85, 94);
            MarkaTxt.Name = "MarkaTxt";
            MarkaTxt.Size = new Size(101, 23);
            MarkaTxt.TabIndex = 5;
            // 
            // ÜrünAdiTxt
            // 
            ÜrünAdiTxt.Location = new Point(85, 130);
            ÜrünAdiTxt.Name = "ÜrünAdiTxt";
            ÜrünAdiTxt.Size = new Size(100, 23);
            ÜrünAdiTxt.TabIndex = 6;
            // 
            // frmÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(528, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += frmÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private TextBox txtSatisFiyati;
        private TextBox txtAlisFiyati;
        private TextBox txtMiktar;
        private TextBox txtÜrünAdi;
        private TextBox txtBarkodNo;
        private GroupBox groupBox2;
        private TextBox SatisFiyatiTxt;
        private TextBox BarkodNotxt;
        private TextBox AlisFiyatiTxt;
        private TextBox Kategoritxt;
        private TextBox MiktarTxt;
        private TextBox MarkaTxt;
        private TextBox ÜrünAdiTxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnYeniEkle;
        private Button btnVarOlanaEkle;
        private Label lblMiktar;
    }
}