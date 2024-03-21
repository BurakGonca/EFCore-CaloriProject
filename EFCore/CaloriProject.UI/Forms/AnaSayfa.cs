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
        

        public AnaSayfa(OgunGir ogun = null)
        {
            ogunGir = ogun ?? new OgunGir(this,Program.kullaniciModel); //user girecek
            
            InitializeComponent();

            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            kullanici_Isım_Lbl.Text = Program.kullaniciModel.Ad + " " + Program.kullaniciModel.Soyad;
            boy_label.Text = Program.kullaniciModel.Boy.ToString();
            kilo_label.Text = Program.kullaniciModel.Kilo.ToString();
            vki_label.Text = (Program.kullaniciModel.Kilo / Math.Pow(Program.kullaniciModel.Boy / 100, 2)).ToString();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            ogunGir.Show();
            this.Hide();

        }
    }
}
