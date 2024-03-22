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
    }
}
