using CaloriProject.UI.Forms;

namespace CaloriProject.UI
{
    public partial class Giris : Form
    {
        private KullaniciGiris kullaniciGiris;
        private UyelikOlusturma UyelikOlusturma;


        public Giris(KullaniciGiris kullanici = null)
        {
            kullaniciGiris = kullanici ?? new KullaniciGiris(this);

            InitializeComponent();
        }

        public Giris(UyelikOlusturma uyelik)
        {
            UyelikOlusturma = uyelik ?? new UyelikOlusturma(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //giris ekrani
        {
            kullaniciGiris.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyelikOlusturma.Show();
            this.Hide();
        }
    }
}
