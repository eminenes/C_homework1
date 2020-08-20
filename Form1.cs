
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 YAZ DÖNEMİ
**
** ÖDEV NUMARASI..........: 1.Ödev
** ÖĞRENCİ ADI............: ABDULLAH ENES TANIŞ
** ÖĞRENCİ NUMARASI.......: B191200019
** DERSİN ALINDIĞI GRUP...: A Grubu
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        int kazanc = 0; // toplam kazancı bu değişkende tutuyorum.
        ArrayList araclar = new ArrayList(); // gir çık yapan araçları burada tutuyorum.
        ArrayList fis = new ArrayList(); // burada da kendi raporumu tutuyorum. Kazancımı bu liste aracılığı ile görüyorum.
         int giris = 0; // toplam giren araç sayısını burada tutuyorum.

        int arac_sayisi = 0; //anlık araç sayısını burada tutuyorum.
        public Form1()
        {
            InitializeComponent();
           


        }

        private void arac_cikar_CheckedChanged(object sender, EventArgs e)
        {
            
            veri_girisi.Visible = false;    
            veri_aktar.Visible = true;
            uyari.Visible = true;
            uyari.Text = "Araç plakası seçin : ";
            veri_aktar.Text = "Aracı çıkar";
            saat.Visible = true;
            saat.Text = "Kaç saat kaldı?";

        }
        //visible komutlarıyla o an hangi araçlara ihtiyacım varsa onları görüyoruz. İhtiyacımız olmayanlar gizleniyor.
        //Bu sayede aynı işi yapacak textboxları çoğaltmak yerine tek işlemde çözüyorum hepsini.
        private void arac_ekle_CheckedChanged(object sender, EventArgs e)
        {

            sonuc.Text = "";
            veri_girisi.Visible = true;
            veri_aktar.Visible = true;
            uyari.Visible = false;
            saat.Visible = false;
            uyari.Text = "Araç plakası girin : ";
            veri_aktar.Text = "Araç Ekle";
         
        }

        private void veri_aktar_Click(object sender, EventArgs e) // butona tıklandığında hangi seçenek seçili ise ona göre iş yapmasını burada kontrol ettim.
        {
            if(arac_ekle.Checked) 
            {
                
                sonuc.Text = (veri_girisi.Text + " Plakalı araç eklendi.");
                araclar.Add(veri_girisi.Text);
                arac_sayisi++; // anlık araç sayısı artışı
                giris++; // toplam giren araç sayısı artışı
                otoparktaki_arac_sayisi.Text = ("Otoparktaki Araç Sayısı : " + arac_sayisi);
                plaka_listesi.Items.Add(veri_girisi.Text); //araçlarımı listbox'a ekliyorum.
            }
            else if(arac_cikar.Checked)
            {

                sonuc.Text = (plaka_listesi.SelectedItem + " Plakalı araç çıkarıldı\nKazanç : " + Convert.ToInt32(saat.Text) * 15); //araçları bir listbox'a ekliyorum. Bu şekilde yönetimi daha kolay olur.
                kazanc = kazanc + (Convert.ToInt32(saat.Text) * 15); // toplam kazancım araç parktan çıktığı için etkileniyor.
                fis.Add(plaka_listesi.SelectedItem + " Plakalı araç " + saat.Text + " saat otoparkta kaldı." + " Bu araçtan kazanç : " + Convert.ToInt32(saat.Text) * 15); // araçları raporlamak için burada tutuyorum.
                arac_sayisi--; 
                otoparktaki_arac_sayisi.Text = ("Otoparktaki Araç Sayısı : " + arac_sayisi); // anlık araç sayısı
              
            }
            else if(kazanc_goster.Checked)
            {
                foreach (object araba in fis) // fis listesindeki nesneleri araba diye adlandırım rapor listeme ekletiyorum.
                {
                    rapor.Items.Add(araba);
                }
            }


        }

     

        private void kazanc_goster_CheckedChanged(object sender, EventArgs e)
        {
            rapor.Visible = true;
            veri_aktar.Text = "Raporu Göster";
            saat.Visible = false;
            veri_aktar.Visible = true;
            uyari.Visible = false;
            veri_girisi.Visible = false;
            sonuc.Text = "Toplam Kazanç : " + kazanc;
            otoparktaki_arac_sayisi.Text = "Toplam bugün kayıt edilen araç : " + giris;
            

        }
    }
}
