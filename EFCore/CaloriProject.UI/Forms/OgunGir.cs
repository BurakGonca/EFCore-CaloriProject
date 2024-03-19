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
    public partial class OgunGir : Form
    {
        private AnaSayfa anaSayfa;

        public OgunGir(AnaSayfa ana)
        {
            anaSayfa = ana;
            InitializeComponent();

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Hide();

        }
    }
}
