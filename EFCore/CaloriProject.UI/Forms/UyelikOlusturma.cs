using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CaloriProject.DAL.Context;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Enums;
using System.Net.Mail;
using System.Text.RegularExpressions;
using CaloriProject.BLL.Manager.Concrete;
using Azure.Core;

namespace CaloriProject.UI.Forms
{
    public partial class UyelikOlusturma : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();

        private Giris giris;

        

        public UyelikOlusturma(Giris gir)
        {
            giris = gir;
            InitializeComponent();
        }





        private void UyelikOlusturma_Load(object sender, EventArgs e)
        {



        }

        private void btn_Olustur_Click(object sender, EventArgs e) //uyelik olusturma butonu.
        {
            KullaniciModel kullaniciModel = new KullaniciModel();


            if (!AlanKontrol(ad_textBox.Text))
            {
                MessageBox.Show("Lütfen adınızı giriniz.");
                return;
            }
            kullaniciModel.Ad = ad_textBox.Text.Trim();


            if (!AlanKontrol(soyad_textBox.Text))
            {
                MessageBox.Show("Lütfen soyadınızı giriniz.");
                return;
            }
            kullaniciModel.Soyad = soyad_textBox.Text.Trim();


            //cinsiyet secimi yaptiriyorum
            if (radioButton_Erkek.Checked)
                kullaniciModel.Cinsiyet = Cinsiyet.Erkek;
            else if (radioButton_Kadin.Checked)
                kullaniciModel.Cinsiyet = Cinsiyet.Kadın;
            else
            {
                MessageBox.Show("Lütfen Cinsiyetinizi Seciniz");
                return;
            }



            //dogumtarihi icin 18-45 yas siniri
            int yas = (DateTime.Now.Year - DogumTarihi_dateTimePicker.Value.Year);
            if (yas < 18 || yas>45)
            {
                MessageBox.Show("Üzgünüz, programımız yalnizca 18 yas ve 45 yas araligi icindir");
                return;
            }
            kullaniciModel.DogumTarihi = DogumTarihi_dateTimePicker.Value;

            if (!AlanKontrol(kilo_textBox.Text))
            {
                MessageBox.Show("Lütfen kilonuzu giriniz.");
                return;
            }
            double kilo= double.Parse(kilo_textBox.Text.Trim());
            if (kilo<=40 || kilo>=120)
            {
                MessageBox.Show("Kilonuz 40-120 deger araliginin disindadir.");
                return;
            }
            kullaniciModel.Kilo = kilo;
           
            if (!AlanKontrol(boy_textBox.Text))
            {
                MessageBox.Show("Lütfen boyunuzu giriniz.");
                return;
            }
            double boy = double.Parse(boy_textBox.Text.Trim());
            if (boy<150 || boy>210)
            {
                MessageBox.Show("Boyunuz 150-210 deger araliginin disindadir.");
                return;

            }
            kullaniciModel.Boy = boy;

            if (!AlanKontrol(eMail_textBox.Text))
            {
                MessageBox.Show("Lütfen e-mailinizi giriniz.");
                return;
            }

            if (!EMailKontrol(eMail_textBox.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-mail adresi giriniz.");
                return;
            }
            kullaniciModel.EMail = eMail_textBox.Text.Trim(); ;

            if (!AlanKontrol(sifre_textBox.Text))
            {
                MessageBox.Show("Lütfen sifrenizi giriniz.");
                return;
            }

            if (!SifreKontrol(sifre_textBox.Text))
            {
                MessageBox.Show("Şifre geçerli değil. Şifre en az 1 büyük harf, en az 1 küçük harf, en az 1 rakam içermeli ve 8-20 karakter uzunluğunda olmalıdır.");
                return;
            }
           

            if (!AlanKontrol(sifreTekrar_textBox.Text))
            {
                MessageBox.Show("Lütfen tekrar sifrenizi giriniz.");
                return;
            }

            if (sifre_textBox.Text != sifreTekrar_textBox.Text)
            {
                MessageBox.Show("Şifreniz ile şifre tekrarınız uyuşmuyor, lütfen kontrol ediniz.");
                return;
            }
            kullaniciModel.Sifre = sifre_textBox.Text;

            // Tüm kontroller başarılı ise kullanıcıyı ekleyebiliriz

            kullaniciManager.Add(kullaniciModel);
            MessageBox.Show("Verdiginiz bilgiler icin tesekkür ederiz, üyeliginiz basariyla olusturuldu.");

            giris.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris.Show();
            this.Hide();
        }


        public static bool EMailKontrol(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool SifreKontrol(string sifre)
        {
            // Sifre en az 8, en fazla 20 karakterden oluşmalı
            if (sifre.Length < 8 || sifre.Length > 20)
                return false;

            // En az bir büyük harf içermeli
            if (!Regex.IsMatch(sifre, "[A-Z]"))
                return false;

            // En az bir küçük harf içermeli
            if (!Regex.IsMatch(sifre, "[a-z]"))
                return false;

            // En az bir rakam içermeli
            if (!Regex.IsMatch(sifre, "[0-9]"))
                return false;

            // Diğer tüm koşullar sağlanıyorsa, sifre geçerlidir
            return true;
        }


        public static bool AlanKontrol(string alan)
        {
            if (string.IsNullOrWhiteSpace(alan)) // Alanın boş olup olmadığını kontrol ediyoruz
                return false;
            return true;
        }



    }
}
