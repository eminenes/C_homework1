namespace WindowsFormsApp11
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
            this.veri_aktar = new System.Windows.Forms.Button();
            this.veri_girisi = new System.Windows.Forms.TextBox();
            this.arac_ekle = new System.Windows.Forms.RadioButton();
            this.arac_cikar = new System.Windows.Forms.RadioButton();
            this.kazanc_goster = new System.Windows.Forms.RadioButton();
            this.uyari = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.TextBox();
            this.otoparktaki_arac_sayisi = new System.Windows.Forms.Label();
            this.rapor = new System.Windows.Forms.ListBox();
            this.plaka_listesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // veri_aktar
            // 
            this.veri_aktar.Location = new System.Drawing.Point(52, 167);
            this.veri_aktar.Name = "veri_aktar";
            this.veri_aktar.Size = new System.Drawing.Size(348, 38);
            this.veri_aktar.TabIndex = 0;
            this.veri_aktar.Text = "Gönder";
            this.veri_aktar.UseVisualStyleBackColor = true;
            this.veri_aktar.Visible = false;
            this.veri_aktar.Click += new System.EventHandler(this.veri_aktar_Click);
            // 
            // veri_girisi
            // 
            this.veri_girisi.Location = new System.Drawing.Point(243, 48);
            this.veri_girisi.Name = "veri_girisi";
            this.veri_girisi.Size = new System.Drawing.Size(157, 20);
            this.veri_girisi.TabIndex = 1;
            this.veri_girisi.Visible = false;
            // 
            // arac_ekle
            // 
            this.arac_ekle.AutoSize = true;
            this.arac_ekle.Location = new System.Drawing.Point(52, 53);
            this.arac_ekle.Name = "arac_ekle";
            this.arac_ekle.Size = new System.Drawing.Size(71, 17);
            this.arac_ekle.TabIndex = 3;
            this.arac_ekle.TabStop = true;
            this.arac_ekle.Text = "Araç Ekle";
            this.arac_ekle.UseVisualStyleBackColor = true;
            this.arac_ekle.CheckedChanged += new System.EventHandler(this.arac_ekle_CheckedChanged);
            // 
            // arac_cikar
            // 
            this.arac_cikar.AutoSize = true;
            this.arac_cikar.Location = new System.Drawing.Point(52, 87);
            this.arac_cikar.Name = "arac_cikar";
            this.arac_cikar.Size = new System.Drawing.Size(74, 17);
            this.arac_cikar.TabIndex = 4;
            this.arac_cikar.TabStop = true;
            this.arac_cikar.Text = "Araç Çıkar";
            this.arac_cikar.UseVisualStyleBackColor = true;
            this.arac_cikar.CheckedChanged += new System.EventHandler(this.arac_cikar_CheckedChanged);
            // 
            // kazanc_goster
            // 
            this.kazanc_goster.AutoSize = true;
            this.kazanc_goster.Location = new System.Drawing.Point(52, 120);
            this.kazanc_goster.Name = "kazanc_goster";
            this.kazanc_goster.Size = new System.Drawing.Size(95, 17);
            this.kazanc_goster.TabIndex = 5;
            this.kazanc_goster.TabStop = true;
            this.kazanc_goster.Text = "Kazanç Göster";
            this.kazanc_goster.UseVisualStyleBackColor = true;
            this.kazanc_goster.CheckedChanged += new System.EventHandler(this.kazanc_goster_CheckedChanged);
            // 
            // uyari
            // 
            this.uyari.AutoSize = true;
            this.uyari.Location = new System.Drawing.Point(240, 23);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(0, 13);
            this.uyari.TabIndex = 6;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(240, 89);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 13);
            this.sonuc.TabIndex = 7;
            // 
            // saat
            // 
            this.saat.Location = new System.Drawing.Point(243, 137);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(157, 20);
            this.saat.TabIndex = 8;
            this.saat.Visible = false;
            // 
            // otoparktaki_arac_sayisi
            // 
            this.otoparktaki_arac_sayisi.AutoSize = true;
            this.otoparktaki_arac_sayisi.Location = new System.Drawing.Point(240, 118);
            this.otoparktaki_arac_sayisi.Name = "otoparktaki_arac_sayisi";
            this.otoparktaki_arac_sayisi.Size = new System.Drawing.Size(126, 13);
            this.otoparktaki_arac_sayisi.TabIndex = 9;
            this.otoparktaki_arac_sayisi.Text = "Otoparktaki Araç Sayısı : ";
            // 
            // rapor
            // 
            this.rapor.FormattingEnabled = true;
            this.rapor.Location = new System.Drawing.Point(52, 211);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(524, 95);
            this.rapor.TabIndex = 10;
            this.rapor.Visible = false;
            // 
            // plaka_listesi
            // 
            this.plaka_listesi.FormattingEnabled = true;
            this.plaka_listesi.Location = new System.Drawing.Point(419, 48);
            this.plaka_listesi.Name = "plaka_listesi";
            this.plaka_listesi.Size = new System.Drawing.Size(157, 160);
            this.plaka_listesi.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 333);
            this.Controls.Add(this.plaka_listesi);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.otoparktaki_arac_sayisi);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.kazanc_goster);
            this.Controls.Add(this.arac_cikar);
            this.Controls.Add(this.arac_ekle);
            this.Controls.Add(this.veri_girisi);
            this.Controls.Add(this.veri_aktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button veri_aktar;
        private System.Windows.Forms.TextBox veri_girisi;
        private System.Windows.Forms.RadioButton arac_ekle;
        private System.Windows.Forms.RadioButton arac_cikar;
        private System.Windows.Forms.RadioButton kazanc_goster;
        private System.Windows.Forms.Label uyari;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.TextBox saat;
        private System.Windows.Forms.Label otoparktaki_arac_sayisi;
        private System.Windows.Forms.ListBox rapor;
        private System.Windows.Forms.ListBox plaka_listesi;
    }
}

