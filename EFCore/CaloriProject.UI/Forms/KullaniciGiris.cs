namespace CaloriProject.UI;
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
using CaloriProject.UI.Forms;
using CaloriProject.BLL.Models;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Policy;
using CaloriProject.DAL.Context;
using CaloriProject.BLL.Manager.Concrete;

public partial class KullaniciGiris : Form
{


    private Giris giris;
    private AnaSayfa anaSayfa;

    public KullaniciGiris(Giris gir, AnaSayfa ana = null)
    {
        giris = gir;

        anaSayfa = ana ?? new AnaSayfa(this);

        InitializeComponent();

    }



    private void KullaniciGiris_Load(object sender, EventArgs e)
    {

    }

    private void btn_girisYap_Click(object sender, EventArgs e) //kullanici giris butonu
    {
        if (!UyelikOlusturma.AlanKontrol(email_textBox.Text))
        {
            MessageBox.Show("Lütfen e-mailinizi giriniz");
            return;
        }
        if (!UyelikOlusturma.EMailKontrol(email_textBox.Text))
        {
            MessageBox.Show("Lütfen geçerli bir e-mail adresi giriniz.");
            return;
        }
        if (!UyelikOlusturma.AlanKontrol(sifre_textBox.Text))
        {
            MessageBox.Show("Lütfen sifrenizi giriniz");
            return;
        }

        if (!UyelikOlusturma.SifreKontrol(sifre_textBox.Text))
        {
            MessageBox.Show("Şifre geçerli değil. Şifre en az 1 büyük harf, en az 1 küçük harf, en az 1 rakam içermeli ve 8-10 karakter uzunluğunda olmalıdır.");
            return;
        }


        KullaniciManager kullaniciManager = new KullaniciManager();


        KullaniciModel kullanici = kullaniciManager.KullaniciModelBul(email_textBox.Text, sifre_textBox.Text);



        if (kullanici != null) // Kullanıcı bulunduysa
        {
            
            Program.KullaniciModel = kullanici;

            KullaniciOgunYiyecekManager manager = new KullaniciOgunYiyecekManager();
            List<KullaniciOgunYiyecekModel> model = manager.Search(k => k.KullaniciID == kullanici.Id);
            Program.KullaniciModel.KullaniciOgunYiyecekModeller = model;

            MessageBox.Show("Giriş başarılı. Ana sayfaya yönlendiriliyorsunuz.");
            anaSayfa.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("E-mail adresi veya şifre hatalı.");
            return;
        }






    }

    private void button1_Click(object sender, EventArgs e) //giris sayfasina geri dönüs
    {

        giris.Show();
        this.Hide();

    }



}

