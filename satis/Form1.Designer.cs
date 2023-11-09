namespace satis
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtAdsoyad = new TextBox();
            textTc = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtBarkodNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatisFiyatı = new TextBox();
            txtMiktar = new TextBox();
            txtÜrünAdı = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnSatışİptal = new Button();
            btnSatışYap = new Button();
            label9 = new Label();
            lblGenelToplam = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(271, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(570, 245);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdsoyad);
            groupBox1.Controls.Add(textTc);
            groupBox1.Location = new Point(19, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 80);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(94, 77);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 1;
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(94, 48);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(100, 23);
            txtAdsoyad.TabIndex = 0;
            // 
            // textTc
            // 
            textTc.Location = new Point(94, 17);
            textTc.Name = "textTc";
            textTc.Size = new Size(100, 23);
            textTc.TabIndex = 0;
            textTc.TextChanged += textTc_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatisFiyatı);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtÜrünAdı);
            groupBox2.Location = new Point(19, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 189);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(7, 146);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 8;
            label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 117);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 7;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 88);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 6;
            label6.Text = "Miktarı\r\n";
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(94, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 2;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 59);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 5;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(94, 138);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(100, 23);
            txtToplamFiyat.TabIndex = 3;
            // 
            // txtSatisFiyatı
            // 
            txtSatisFiyatı.Location = new Point(94, 109);
            txtSatisFiyatı.Name = "txtSatisFiyatı";
            txtSatisFiyatı.Size = new Size(100, 23);
            txtSatisFiyatı.TabIndex = 3;
            txtSatisFiyatı.TextChanged += txtSatisFiyatı_TextChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(94, 80);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 2;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(94, 51);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(100, 23);
            txtÜrünAdı.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(288, 375);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(847, 98);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatışİptal
            // 
            btnSatışİptal.Location = new Point(847, 123);
            btnSatışİptal.Name = "btnSatışİptal";
            btnSatışİptal.Size = new Size(75, 23);
            btnSatışİptal.TabIndex = 5;
            btnSatışİptal.Text = "Satış İptal";
            btnSatışİptal.UseVisualStyleBackColor = true;
            btnSatışİptal.Click += btnSatışİptal_Click;
            // 
            // btnSatışYap
            // 
            btnSatışYap.Location = new Point(766, 371);
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(75, 23);
            btnSatışYap.TabIndex = 6;
            btnSatışYap.Text = "Satış Yap";
            btnSatışYap.UseVisualStyleBackColor = true;
            btnSatışYap.Click += btnSatışYap_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(482, 379);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 9;
            label9.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenelToplam.Location = new Point(595, 379);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(7, 15);
            lblGenelToplam.TabIndex = 10;
            lblGenelToplam.Text = "\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 73);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(847, 12);
            button2.Name = "button2";
            button2.Size = new Size(119, 36);
            button2.TabIndex = 18;
            button2.Text = "Satışları Listeleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(709, 12);
            button1.Name = "button1";
            button1.Size = new Size(119, 36);
            button1.TabIndex = 17;
            button1.Text = "Kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(571, 12);
            button9.Name = "button9";
            button9.Size = new Size(119, 36);
            button9.TabIndex = 16;
            button9.Text = "Marka";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(423, 12);
            button8.Name = "button8";
            button8.Size = new Size(129, 36);
            button8.TabIndex = 15;
            button8.Text = "Ürün Listeleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(281, 12);
            button7.Name = "button7";
            button7.Size = new Size(123, 36);
            button7.TabIndex = 14;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(147, 12);
            button6.Name = "button6";
            button6.Size = new Size(115, 36);
            button6.TabIndex = 13;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 12);
            button5.Name = "button5";
            button5.Size = new Size(125, 36);
            button5.TabIndex = 12;
            button5.Text = "Müşteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(973, 450);
            Controls.Add(panel1);
            Controls.Add(lblGenelToplam);
            Controls.Add(label9);
            Controls.Add(btnSatışYap);
            Controls.Add(btnSatışİptal);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtBarkodNo;
        private TextBox txtTelefon;
        private TextBox txtAdsoyad;
        private GroupBox groupBox2;
        private TextBox txtToplamFiyat;
        private TextBox txtSatisFiyatı;
        private TextBox txtMiktar;
        private TextBox txtÜrünAdı;
        private TextBox textTc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnEkle;
        private Button btnSil;
        private Button btnSatışİptal;
        private Button btnSatışYap;
        private Label label9;
        private Label lblGenelToplam;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
    }
}