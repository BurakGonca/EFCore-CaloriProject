using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.MappingProfile;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Abstract;
using CaloriProject.DAL.Repostory.Concrete;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaloriProject.UI.Forms
{

    public partial class AyarlarSayfasi : Form
    {
        private AnaSayfa anaSayfa;
        private KullaniciGiris kullaniciGiris;

                
        KullaniciManager kullaniciManager = new KullaniciManager();

        private KullaniciModel kullaniciModel;

        public AyarlarSayfasi(AnaSayfa ana, KullaniciGiris kullanici , KullaniciModel kullanici1)
        {
            kullaniciModel = kullanici1;
            Program.AktifSayfa = this;
            anaSayfa = ana;
            kullaniciGiris = kullanici;
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e) //anasayfaya donus
        {
            Program.AktifSayfa.Hide();
            anaSayfa.Show();
        }

        private void AyarlarSayfasi_Load(object sender, EventArgs e)
        {
            txt_Ad.Text = kullaniciModel.Ad;
            txt_Soyad.Text = kullaniciModel.Soyad; ;
            txt_Boy.Text = kullaniciModel.Boy.ToString();
            txt_Kilo.Text = kullaniciModel.Kilo.ToString();
            txt_Sifre.Text = kullaniciModel.Sifre;
            dogumTarihiPicker.Text = kullaniciModel.DogumTarihi.ToShortDateString();

        }



        private void btn_Kaydet_Click(object sender, EventArgs e)
        {




            
            kullaniciModel.Ad = txt_Ad.Text;
            kullaniciModel.Soyad = txt_Soyad.Text;
            kullaniciModel.Boy = Convert.ToDouble(txt_Boy.Text);
            kullaniciModel.Kilo = Convert.ToDouble(txt_Kilo.Text);
            //Program.kullaniciModel.EMail = yeniEmail;
            kullaniciModel.DogumTarihi = Convert.ToDateTime(dogumTarihiPicker.Text);
            kullaniciModel.Sifre = txt_Sifre.Text;
            





            DialogResult result = MessageBox.Show("Profil güncellenecek onaylıyor musun?", "Onaylıyorum", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                kullaniciManager.Update(kullaniciModel);
                MessageBox.Show("Profil başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Profili silmek istiyor musun?", "Evet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                kullaniciManager.Remove(kullaniciModel);
                MessageBox.Show("Profil başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.AktifSayfa.Hide();
                kullaniciGiris.Show();
                
            }



        }
    }
}
