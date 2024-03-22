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
using CaloriProject.UI.Forms;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;

namespace CaloriProject.UI
{
    public partial class YiyecekEkle : Form
    {
        YiyecekManager yiyecekManager = new YiyecekManager();
        CaloriDBContext CaloriDBContext = new CaloriDBContext();
        private AnaSayfa anaSayfa;

        public YiyecekEkle(AnaSayfa ana)
        {
            anaSayfa = ana;
            InitializeComponent();
        }

        

        private void YiyecekEkle_Load(object sender, EventArgs e)
        {
            kategori_combobox.DataSource = CaloriDBContext.Kategoriler.ToList();

        }



        

        private void txt_kalori_TextChanged(object sender, EventArgs e)
        {
            void txt_kalori_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    
                    int porsiyon = int.Parse(txt_kalori.Text);
                    
                }
                catch (FormatException)
                {
                    
                    MessageBox.Show("Lütfen sadece sayı giriniz.");
                    
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

           
            TextBox[] textBoxes = { txt_kalori, txt_yiyecekAdi };

            foreach (TextBox textBox in textBoxes)
            {
                // TextBox boşsa hata mesajı gösterir
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Lütfen boş alanları doldurun.");
                    return;
                }
            }

           

            yiyecekModel.YiyecekAdi = txt_yiyecekAdi.Text.Trim();
            yiyecekModel.Kalori = Convert.ToDouble(txt_kalori.Text.Trim());
            yiyecekModel.Porsiyon = 1;

            if (kategori_combobox.SelectedItem != null)
            {
                yiyecekModel.KategoriID = ((Kategori)(kategori_combobox.SelectedItem)).Id;
            }
                
            else
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
                return;
            }

            
            yiyecekManager.Add(yiyecekModel);

            MessageBox.Show("Başarılı.");

            txt_kalori.Clear();
            
            txt_yiyecekAdi.Clear();
        }

        private void anaSayfa_buton_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Hide();
        }
    }
}
