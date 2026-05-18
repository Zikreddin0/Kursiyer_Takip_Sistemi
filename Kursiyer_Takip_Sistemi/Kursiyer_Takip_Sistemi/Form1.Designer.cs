namespace Kursiyer_Takip_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKursNo = new System.Windows.Forms.TextBox();
            this.KursiyerKaydetButonu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYoklamaKursiyerNo = new System.Windows.Forms.TextBox();
            this.chkGeldiMi = new System.Windows.Forms.CheckBox();
            this.YoklamaKaydetButonu = new System.Windows.Forms.Button();
            this.ListeleButonu = new System.Windows.Forms.Button();
            this.dataGridViewKursiyerler = new System.Windows.Forms.DataGridView();
            this.YoklamaListeleButonu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSilKursiyerNo = new System.Windows.Forms.TextBox();
            this.KursiyerSilButonu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKursiyerler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(74, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(74, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(74, 128);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kurs Numarası (ID):";
            // 
            // txtKursNo
            // 
            this.txtKursNo.Location = new System.Drawing.Point(139, 181);
            this.txtKursNo.Name = "txtKursNo";
            this.txtKursNo.Size = new System.Drawing.Size(100, 22);
            this.txtKursNo.TabIndex = 7;
            // 
            // KursiyerKaydetButonu
            // 
            this.KursiyerKaydetButonu.Location = new System.Drawing.Point(15, 229);
            this.KursiyerKaydetButonu.Name = "KursiyerKaydetButonu";
            this.KursiyerKaydetButonu.Size = new System.Drawing.Size(118, 23);
            this.KursiyerKaydetButonu.TabIndex = 8;
            this.KursiyerKaydetButonu.Text = "Kursiyer Kaydet";
            this.KursiyerKaydetButonu.UseVisualStyleBackColor = true;
            this.KursiyerKaydetButonu.Click += new System.EventHandler(this.KursiyerKaydetButonu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kursiyer Numarası (ID):";
            // 
            // txtYoklamaKursiyerNo
            // 
            this.txtYoklamaKursiyerNo.Location = new System.Drawing.Point(624, 52);
            this.txtYoklamaKursiyerNo.Name = "txtYoklamaKursiyerNo";
            this.txtYoklamaKursiyerNo.Size = new System.Drawing.Size(100, 22);
            this.txtYoklamaKursiyerNo.TabIndex = 10;
            // 
            // chkGeldiMi
            // 
            this.chkGeldiMi.AutoSize = true;
            this.chkGeldiMi.Location = new System.Drawing.Point(599, 107);
            this.chkGeldiMi.Name = "chkGeldiMi";
            this.chkGeldiMi.Size = new System.Drawing.Size(125, 20);
            this.chkGeldiMi.TabIndex = 11;
            this.chkGeldiMi.Text = "Derse Geldi mi?";
            this.chkGeldiMi.UseVisualStyleBackColor = true;
            // 
            // YoklamaKaydetButonu
            // 
            this.YoklamaKaydetButonu.Location = new System.Drawing.Point(451, 145);
            this.YoklamaKaydetButonu.Name = "YoklamaKaydetButonu";
            this.YoklamaKaydetButonu.Size = new System.Drawing.Size(140, 23);
            this.YoklamaKaydetButonu.TabIndex = 12;
            this.YoklamaKaydetButonu.Text = "Yoklama Kaydet";
            this.YoklamaKaydetButonu.UseVisualStyleBackColor = true;
            this.YoklamaKaydetButonu.Click += new System.EventHandler(this.YoklamaKaydetButonu_Click);
            // 
            // ListeleButonu
            // 
            this.ListeleButonu.Location = new System.Drawing.Point(451, 242);
            this.ListeleButonu.Name = "ListeleButonu";
            this.ListeleButonu.Size = new System.Drawing.Size(140, 23);
            this.ListeleButonu.TabIndex = 13;
            this.ListeleButonu.Text = "Kursiyerleri Listele";
            this.ListeleButonu.UseVisualStyleBackColor = true;
            this.ListeleButonu.Click += new System.EventHandler(this.ListeleButonu_Click);
            // 
            // dataGridViewKursiyerler
            // 
            this.dataGridViewKursiyerler.AllowUserToAddRows = false;
            this.dataGridViewKursiyerler.AllowUserToDeleteRows = false;
            this.dataGridViewKursiyerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKursiyerler.Location = new System.Drawing.Point(451, 291);
            this.dataGridViewKursiyerler.Name = "dataGridViewKursiyerler";
            this.dataGridViewKursiyerler.ReadOnly = true;
            this.dataGridViewKursiyerler.RowHeadersWidth = 51;
            this.dataGridViewKursiyerler.RowTemplate.Height = 24;
            this.dataGridViewKursiyerler.Size = new System.Drawing.Size(330, 150);
            this.dataGridViewKursiyerler.TabIndex = 14;
            // 
            // YoklamaListeleButonu
            // 
            this.YoklamaListeleButonu.Location = new System.Drawing.Point(599, 242);
            this.YoklamaListeleButonu.Name = "YoklamaListeleButonu";
            this.YoklamaListeleButonu.Size = new System.Drawing.Size(182, 23);
            this.YoklamaListeleButonu.TabIndex = 15;
            this.YoklamaListeleButonu.Text = "Yoklama Kayıtlarını Göster";
            this.YoklamaListeleButonu.UseVisualStyleBackColor = true;
            this.YoklamaListeleButonu.Click += new System.EventHandler(this.YoklamaListeleButonu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Silinecek Kursiyer ID:";
            // 
            // txtSilKursiyerNo
            // 
            this.txtSilKursiyerNo.Location = new System.Drawing.Point(160, 323);
            this.txtSilKursiyerNo.Name = "txtSilKursiyerNo";
            this.txtSilKursiyerNo.Size = new System.Drawing.Size(100, 22);
            this.txtSilKursiyerNo.TabIndex = 17;
            // 
            // KursiyerSilButonu
            // 
            this.KursiyerSilButonu.Location = new System.Drawing.Point(15, 376);
            this.KursiyerSilButonu.Name = "KursiyerSilButonu";
            this.KursiyerSilButonu.Size = new System.Drawing.Size(118, 23);
            this.KursiyerSilButonu.TabIndex = 18;
            this.KursiyerSilButonu.Text = "Kursiyer Sil";
            this.KursiyerSilButonu.UseVisualStyleBackColor = true;
            this.KursiyerSilButonu.Click += new System.EventHandler(this.KursiyerSilButonu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kursiyer Kayıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kursiyer Kayıt Silme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kursiyer Devam Takip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KursiyerSilButonu);
            this.Controls.Add(this.txtSilKursiyerNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YoklamaListeleButonu);
            this.Controls.Add(this.dataGridViewKursiyerler);
            this.Controls.Add(this.ListeleButonu);
            this.Controls.Add(this.YoklamaKaydetButonu);
            this.Controls.Add(this.chkGeldiMi);
            this.Controls.Add(this.txtYoklamaKursiyerNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KursiyerKaydetButonu);
            this.Controls.Add(this.txtKursNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKursiyerler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKursNo;
        private System.Windows.Forms.Button KursiyerKaydetButonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYoklamaKursiyerNo;
        private System.Windows.Forms.CheckBox chkGeldiMi;
        private System.Windows.Forms.Button YoklamaKaydetButonu;
        private System.Windows.Forms.Button ListeleButonu;
        private System.Windows.Forms.DataGridView dataGridViewKursiyerler;
        private System.Windows.Forms.Button YoklamaListeleButonu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSilKursiyerNo;
        private System.Windows.Forms.Button KursiyerSilButonu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

