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
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = String;

public partial class KullaniciGiris : Form
{

   
    private Giris giris;
    private AnaSayfa anaSayfa;

    public KullaniciGiris(Giris gir)
    {
        giris = gir;
        
        InitializeComponent();
    }


    public KullaniciGiris(AnaSayfa ana)
    {
        anaSayfa = ana;
        InitializeComponent();
    }



    private void KullaniciGiris_Load(object sender, EventArgs e)
    {

    }

    private void btn_girisYap_Click(object sender, EventArgs e) //kullanici giris butonu
    {



        anaSayfa.Show();
        this.Hide();
    }

    private void button1_Click(object sender, EventArgs e) //giris sayfasina geri dönüs
    {

        giris.Show();
        this.Hide();

    }
}

