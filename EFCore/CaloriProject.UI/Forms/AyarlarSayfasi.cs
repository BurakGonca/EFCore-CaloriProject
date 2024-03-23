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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaloriProject.UI.Forms
{

    public partial class AyarlarSayfasi : Form
    {
        private AnaSayfa anaSayfa;
        private KullaniciGiris kullaniciGiris;

                
        KullaniciManager kullaniciManager = new KullaniciManager();
        

        public AyarlarSayfasi(AnaSayfa ana, KullaniciGiris kullanici)
        {
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
            txt_Ad.Text = Program.KullaniciModel.Ad;
            txt_Soyad.Text = Program.KullaniciModel.Soyad; ;
            txt_Boy.Text = Program.KullaniciModel.Boy.ToString();
            txt_Kilo.Text = Program.KullaniciModel.Kilo.ToString();
            txt_Sifre.Text = Program.KullaniciModel.Sifre;
            dogumTarihiPicker.Text = Program.KullaniciModel.DogumTarihi.ToShortDateString();

        }



        private void btn_Kaydet_Click(object sender, EventArgs e)
        {




            
            Program.KullaniciModel.Ad = txt_Ad.Text;
            Program.KullaniciModel.Soyad = txt_Soyad.Text;
            Program.KullaniciModel.Boy = Convert.ToDouble(txt_Boy.Text);
            Program.KullaniciModel.Kilo = Convert.ToDouble(txt_Kilo.Text);
            //Program.kullaniciModel.EMail = yeniEmail;
            Program.KullaniciModel.DogumTarihi = Convert.ToDateTime(dogumTarihiPicker.Text);
            Program.KullaniciModel.Sifre = txt_Sifre.Text;
            





            DialogResult result = MessageBox.Show("Profil güncellenecek onaylıyor musun?", "Onaylıyorum", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                kullaniciManager.Update(Program.KullaniciModel);
                MessageBox.Show("Profil başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Profili silmek istiyor musun?", "Evet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                kullaniciManager.Remove(Program.KullaniciModel);
                MessageBox.Show("Profil başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.AktifSayfa.Hide();
                kullaniciGiris.Show();
                
            }



        }
    }
}
