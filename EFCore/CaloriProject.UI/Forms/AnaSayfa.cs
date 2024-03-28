using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriProject.UI.Forms
{
    public partial class AnaSayfa : Form
    {
        private OgunIslemleri ogunGir;
        private YiyecekEkle yiyecekEkle;
        private KullaniciGiris kullaniciGiris;
        private AyarlarSayfasi ayarlarSayfasi;
        private RaporSayfası raporSayfası;

        private KullaniciModel kullaniciModel;



        public AnaSayfa(KullaniciGiris kullanici, KullaniciModel kullaniciModel2)
        {



            kullaniciGiris = kullanici;
            kullaniciModel = kullaniciModel2;
            ogunGir = new OgunIslemleri(this, kullaniciModel);

            yiyecekEkle = new YiyecekEkle(this);

            ayarlarSayfasi = new AyarlarSayfasi(this, kullaniciGiris, kullaniciModel);
            raporSayfası = new RaporSayfası(this, kullaniciModel);
            Program.AnaSayfa = this;
            Program.AktifSayfa = this;




            InitializeComponent();

        }


        private void AnaSayfa_Load(object sender, EventArgs e)
        {

            KullaniciVerileriGuncelle(Program.KullaniciModel);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            ogunGir.Show();
            this.Hide();

        }

        private void yiyecekEkle_buton_Click(object sender, EventArgs e)
        {
            yiyecekEkle.Show();
            this.Hide();
        }

        private void cikisYap_buton_Click(object sender, EventArgs e) //kullanici cikis islemi
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Program.KullaniciModel = null;
                MessageBox.Show("Cikis yapilmistir.");
                kullaniciGiris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Çıkış işlemi iptal edilmiştir.");
            }




        }

        private void ayarlar_buton_Click(object sender, EventArgs e)
        {
            Program.ReferansSayfa = this;
            Program.AktifSayfa = ayarlarSayfasi;
            Program.AktifSayfa.Show();
            Program.ReferansSayfa.Hide();
        }

        private void raporlar_buton_Click(object sender, EventArgs e)
        {
            Program.ReferansSayfa = this;
            Program.AktifSayfa = raporSayfası;
            Program.AktifSayfa.Show();
            Program.ReferansSayfa.Hide();

        }


        public void KullaniciVerileriGuncelle(KullaniciModel yeniKullanici)
        {

            kullanici_Isım_Lbl.Text = yeniKullanici.Ad + " " + yeniKullanici.Soyad;
            boy_label.Text = yeniKullanici.Boy.ToString();
            kilo_label.Text = yeniKullanici.Kilo.ToString();
            vki_label.Text = (yeniKullanici.Kilo / Math.Pow(yeniKullanici.Boy / 100, 2)).ToString();
            kullanici_label.Text = yeniKullanici.Ad + " " + yeniKullanici.Soyad;

        }

    }
}
