using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriProject.UI.Forms
{
    public partial class OgunGir : Form
    {

        private AnaSayfa anaSayfa;
        KullaniciOgunYiyecekModel secilenOgun;

        KullaniciOgunYiyecekManager kullaniciOgunYiyecekManager = new KullaniciOgunYiyecekManager();

        YiyecekManager YiyecekManager = new YiyecekManager();

        CaloriDBContext CaloriDBContext = new CaloriDBContext();

        public OgunGir(AnaSayfa ana,KullaniciModel kullaniciModel)
        {
            anaSayfa = ana;
            //Program.KullaniciModel= kullaniciModel; //deneme yapıyorum
            InitializeComponent();

        }

        
        private void OgunGir_Load(object sender, EventArgs e)
        {
            kullanici_Isım_Lbl.Text = Program.KullaniciModel.Ad + " " + Program.KullaniciModel.Soyad;
            
            comboBox1_ogun.DataSource = CaloriDBContext.Ogünler.ToList();
            comboBox3_yiyecek.DataSource = YiyecekManager.GetAllWithIncludes();

            //dataGridView1.DataSource = kullaniciOgunYiyecekManager.GetAllWithIncludes();

            dataGridView1.DataSource = Program.KullaniciModel.KullaniciOgunYiyecekModeller.ToList();


            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Hide();

		}

		private void ekle_buton_Click(object sender, EventArgs e)
		{

			KullaniciOgunYiyecekModel kullaniciOgunYiyecekModel = new KullaniciOgunYiyecekModel();

            kullaniciOgunYiyecekModel.KullaniciID = Program.KullaniciModel.Id;


            if (comboBox3_yiyecek.SelectedItem != null)
                kullaniciOgunYiyecekModel.YiyecekID = ((YiyecekModel)comboBox3_yiyecek.SelectedItem).Id;
            else
            {
                MessageBox.Show("Lütfen bir yiyecek seçin.");
                return;
            }


            if (comboBox1_ogun.SelectedItem != null)
                kullaniciOgunYiyecekModel.OgunID = ((Ogun)comboBox1_ogun.SelectedItem).Id;
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
                return;
            }

			kullaniciOgunYiyecekModel.Tarih = dateTimePicker1.Value;

			DialogResult dialog = MessageBox.Show("Öğününüzü eklemek istediğinizden emin misiniz?", "Ekle", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.Yes)
			{



				kullaniciOgunYiyecekManager.Add(kullaniciOgunYiyecekModel);

				MessageBox.Show("Öğün Başarıyla Eklenmiştir!");

				// DataGridView güncellemesi
				dataGridView1.DataSource = null;
                dataGridView1.DataSource = Program.KullaniciModel.KullaniciOgunYiyecekModeller.ToList();

            }
			else
			{
				MessageBox.Show("Öğün Ekleme İptal Edilmiştir.");
			}

           

		}

        private void sil_buton_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                
                kullaniciOgunYiyecekManager.Delete(secilenOgun);
                MessageBox.Show("Öğün silinmiştir.");
                //dataGridView1.DataSource = kullaniciOgunYiyecekManager.GetAllWithIncludes();
                dataGridView1.DataSource = Program.KullaniciModel.KullaniciOgunYiyecekModeller.ToList();
            }
            else
                MessageBox.Show("Secili Öğün Yok!");

		}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (KullaniciOgunYiyecekModel)dataGridView1.SelectedRows[0].DataBoundItem;
            comboBox1_ogun.Text = secilenOgun.OgunModeller.ToString();
            comboBox3_yiyecek.Text = secilenOgun.YiyecekModeller.ToString();

            

		}

		private void guncelle_buton_Click(object sender, EventArgs e)
		{
			if (secilenOgun != null)
			{

				//var guncellenecekOgun = Db.KullaniciOgunYiyecek.FirstOrDefault(k => k.Id == secilenOgun.Id);

				//guncellenecekOgun.UpdatedDate = DateTime.Now;
				//guncellenecekOgun.Yiyecek = (Yiyecek)(comboBox3_yiyecek.SelectedItem);
				//guncellenecekOgun.Ogun = (Ogun)comboBox1_ogun.SelectedItem;
				//guncellenecekOgun.Tarih = dateTimePicker1.Value;

				//koyRepostory.Update(guncellenecekOgun);
				//MessageBox.Show("Öğün guncellenmistir");

				//dataGridView1.DataSource = Db.KullaniciOgunYiyecek.ToList();

			}
			else
				MessageBox.Show("Secili Öğün Yok!");
		}


    }
}
