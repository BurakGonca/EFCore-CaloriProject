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
        private OgunGir ogunGir;
        private YiyecekEkle yiyecekEkle;
        private KullaniciGiris kullaniciGiris;
        private AyarlarSayfasi ayarlarSayfasi;
        private RaporSayfası raporSayfası;
        

        

        public AnaSayfa(KullaniciGiris kullanici)
        {


            kullaniciGiris = kullanici;
            ogunGir =  new OgunGir(this, Program.KullaniciModel);
            yiyecekEkle =  new YiyecekEkle(this);

            ayarlarSayfasi = new AyarlarSayfasi(this, kullaniciGiris);
            raporSayfası = new RaporSayfası(this);
            Program.AnaSayfa = this;
            Program.AktifSayfa= this;

            
            InitializeComponent();


        }


        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            kullanici_Isım_Lbl.Text = Program.KullaniciModel.Ad + " " + Program.KullaniciModel.Soyad;
            boy_label.Text = Program.KullaniciModel.Boy.ToString();
            kilo_label.Text = Program.KullaniciModel.Kilo.ToString();
            vki_label.Text = (Program.KullaniciModel.Kilo / Math.Pow(Program.KullaniciModel.Boy / 100, 2)).ToString();


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
            Program.KullaniciModel = null;
            kullaniciGiris.Show();
            this.Hide();



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


       

    }
}
