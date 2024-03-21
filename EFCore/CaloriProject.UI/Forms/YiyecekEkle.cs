using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Enums;
using System.Net.Mail;
using System.Text.RegularExpressions;
using CaloriProject.BLL.Manager.Concrete;

namespace CaloriProject.UI
{
    public partial class YiyecekEkle : Form
    {
        YiyecekManager yiyecekManager = new YiyecekManager();


        public YiyecekEkle()
        {
            InitializeComponent();
        }

        private void YiyecekEkle_Load(object sender, EventArgs e)
        {

        }

        

        private void txt_Porsiyon_TextChanged(object sender, EventArgs e)
        {
            void txt_Porsiyon_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    // Girilen metni sayıya dönüştürmeye çalış
                    int porsiyon = int.Parse(txt_Porsiyon.Text);
                    // Başarılıysa devam et
                }
                catch (FormatException)
                {
                    // Girilen metin sayıya dönüştürülemezse hata mesajı göster
                    MessageBox.Show("Lütfen sadece sayı giriniz.");
                    // Metni temizle veya geçerli bir değer atayabilirsiniz
                    txt_Porsiyon.Text = "";
                }
            }

        }

        private void txt_kalori_TextChanged(object sender, EventArgs e)
        {
            void txt_kalori_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    // Girilen metni sayıya dönüştürmeye çalış
                    int porsiyon = int.Parse(txt_kalori.Text);
                    // Başarılıysa devam et
                }
                catch (FormatException)
                {
                    // Girilen metin sayıya dönüştürülemezse hata mesajı göster
                    MessageBox.Show("Lütfen sadece sayı giriniz.");
                    // Metni temizle veya geçerli bir değer atayabilirsiniz
                    txt_kalori.Text = "";
                }
            }

        }

        private void txt_yiyecekAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yiyecekEkle_Click(object sender, EventArgs e)
        {
            YiyecekModel yiyecekModel = new YiyecekModel();

            // Boş TextBox'ları kontrol etmek için bir dizi oluşturun
            TextBox[] textBoxes = { txt_Porsiyon, txt_kalori, txt_yiyecekAdi };

            foreach (TextBox textBox in textBoxes)
            {
                // TextBox boşsa hata mesajı göster ve işlemi durdur
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Lütfen boş alanları doldurun.");
                    return;
                }
            }

            // Buraya geldiğinde tüm TextBox'lar dolu demektir, işlemi devam ettirebilirsiniz.

            yiyecekModel.YiyecekAdi=txt_yiyecekAdi.Text.Trim();
            yiyecekModel.Kalori = Convert.ToDouble(txt_kalori.Text.Trim());
            yiyecekModel.Porsiyon = Convert.ToDouble(txt_Porsiyon.Text.Trim());
            yiyecekModel.KategoriID = 2;

            yiyecekManager.Add(yiyecekModel);

            MessageBox.Show("Başarılı.");


        }
    }
}
