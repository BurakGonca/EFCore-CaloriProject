using CaloriProject.UI.Forms;

namespace CaloriProject.UI
{
    public partial class Giris : Form
    {
        private KullaniciGiris kullaniciGiris;
        private UyelikOlusturma UyelikOlusturma;


        public Giris(KullaniciGiris kullanici = null, UyelikOlusturma uyelik = null)
        {
            kullaniciGiris = kullanici ?? new KullaniciGiris(this);
            UyelikOlusturma = uyelik ?? new UyelikOlusturma(this);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e) //uyelik olusturma ekrani
        {
            UyelikOlusturma.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kullaniciGiris.Show();
            this.Hide();
        }
    }
}
