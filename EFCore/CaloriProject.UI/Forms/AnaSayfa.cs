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
        public AnaSayfa()
        {
            InitializeComponent();
            Kullanici kullanici = new Kullanici();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            //kullanici_Isım_Lbl.Text = Kullanici.Ad
        }








    }
}
