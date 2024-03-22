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

        CaloriDBContext db = new CaloriDBContext();
        Kullanici kullanici = new Kullanici();

        public AyarlarSayfasi(AnaSayfa ana)
        {
            Program.AktifSayfa = this;
            anaSayfa = ana;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.AktifSayfa.Hide();
            anaSayfa.Show();
        }

        private void AyarlarSayfasi_Load(object sender, EventArgs e)
        {
            txt_Ad.Text = Program.kullaniciModel.Ad;
            txt_Soyad.Text = Program.kullaniciModel.Soyad; ;
            txt_Boy.Text = Program.kullaniciModel.Boy.ToString();
            txt_Kilo.Text = Program.kullaniciModel.Kilo.ToString();
            txt_Email.Text = Program.kullaniciModel.EMail;
            dogumTarihiPicker.Text = Program.kullaniciModel.DogumTarihi.ToShortDateString();

        }



        private void btn_Kaydet_Click(object sender, EventArgs e)
        {

            var guncelle = db.Kullanicilar.First(x => x.EMail == Program.kullaniciModel.EMail);
            guncelle.Ad = txt_Ad.Text;
            guncelle.Soyad = txt_Soyad.Text;
            guncelle.Boy = Convert.ToDouble(txt_Boy.Text);
            guncelle.Kilo = Convert.ToDouble(txt_Kilo.Text);
            guncelle.DogumTarihi = Convert.ToDateTime(dogumTarihiPicker.Text);
            guncelle.EMail = txt_Email.Text;



            // Program.kullaniciModel içindeki verilerin güncellenmesi
            Program.kullaniciModel.Ad = txt_Ad.Text;
            Program.kullaniciModel.Soyad = txt_Soyad.Text;
            Program.kullaniciModel.Boy = Convert.ToDouble(txt_Boy.Text);
            Program.kullaniciModel.Kilo = Convert.ToDouble(txt_Kilo.Text);
            //Program.kullaniciModel.EMail = yeniEmail;
            Program.kullaniciModel.DogumTarihi = Convert.ToDateTime(dogumTarihiPicker.Text);



            //Veritabanında kullanıcı modelinin güncellenmesi için uygun kodlar buraya yazılmalıdır
            //Örneğin, veritabanı bağlantısı kurma, güncelleme sorgusu oluşturma ve çalıştırma işlemleri burada gerçekleştirilebilir
            //Veritabanı işlemleri için uygun kütüphaneleri ve yöntemleri kullanarak veritabanına güncelleme yapılabilir

            DialogResult result = MessageBox.Show("Profil güncellenecek onaylıyor musun?", "Onaylıyorum", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                kullanici.Update(guncelle);
                MessageBox.Show("Profil başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            var sil = db.Kullanicilar.FirstOrDefault(x => x.EMail == Program.kullaniciModel.EMail);

            DialogResult result = MessageBox.Show("Profili silmek istiyor musun?", "Evet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                kullanici.Delete(sil);
                MessageBox.Show("Profil başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Giris giris = new Giris();
                giris.Show();
                this.Hide();
            }
        }
    }
}
