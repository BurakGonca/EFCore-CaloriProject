using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class OgunIslemleri : Form
    {

        private AnaSayfa anaSayfa;
        KullaniciOgunYiyecekModel secilenOgun;

        KullaniciOgunYiyecekManager kullaniciOgunYiyecekManager = new KullaniciOgunYiyecekManager();

        YiyecekManager YiyecekManager = new YiyecekManager();

        CaloriDBContext CaloriDBContext = new CaloriDBContext();

        private KullaniciModel kullaniciModel;
        private YiyecekModel YiyecekModel;

        public OgunIslemleri(AnaSayfa ana, KullaniciModel kullaniciModel)
        {
            this.kullaniciModel = kullaniciModel;
            anaSayfa = ana;
            InitializeComponent();

        }


        private void OgunGir_Load(object sender, EventArgs e)
        {


            kullanici_Isım_Lbl.Text = kullaniciModel.Ad + " " + kullaniciModel.Soyad;

            comboBox1_ogun.DataSource = CaloriDBContext.Ogünler.ToList();
            comboBox3_yiyecek.DataSource = YiyecekManager.GetAllWithIncludes();

            dataGridView1.DataSource = kullaniciModel.KullaniciOgunYiyecekModeller.ToList();




            

        }


        private void button4_Click(object sender, EventArgs e)
        {

            anaSayfa.Show();
            this.Hide();

        }

        private void ekle_buton_Click(object sender, EventArgs e)
        {

            KullaniciOgunYiyecekModel kullaniciOgunYiyecekModel = new KullaniciOgunYiyecekModel();

            kullaniciOgunYiyecekModel.KullaniciID = kullaniciModel.Id;


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

               

                
                dataGridView1.DataSource = kullaniciOgunYiyecekManager.Search(k => k.KullaniciID == kullaniciOgunYiyecekModel.KullaniciID).ToList();




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
                kullaniciOgunYiyecekManager.Remove(secilenOgun);

                //kullaniciModel.KullaniciOgunYiyecekModeller.Remove(secilenOgun);

                MessageBox.Show("Öğün silinmiştir.");

                //dataGridView1.DataSource = kullaniciModel.KullaniciOgunYiyecekModeller.ToList();

                dataGridView1.DataSource = kullaniciOgunYiyecekManager.Search(k => k.KullaniciID == secilenOgun.KullaniciID).ToList();
            }
            else
                MessageBox.Show("Secili Öğün Yok!");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (KullaniciOgunYiyecekModel)dataGridView1.SelectedRows[0].DataBoundItem;

        }

        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {


                kullaniciOgunYiyecekManager.Update(secilenOgun);


                KullaniciOgunYiyecekModel kullaniciOgunYiyecekModel2 = new KullaniciOgunYiyecekModel();

                kullaniciOgunYiyecekModel2.KullaniciID = kullaniciModel.Id;

                kullaniciOgunYiyecekModel2.YiyecekID = ((YiyecekModel)(comboBox3_yiyecek.SelectedItem)).Id;
                kullaniciOgunYiyecekModel2.OgunID = ((Ogun)comboBox1_ogun.SelectedItem).Id;
                kullaniciOgunYiyecekModel2.Tarih = dateTimePicker1.Value;
                kullaniciOgunYiyecekManager.Add(kullaniciOgunYiyecekModel2);

                MessageBox.Show("Öğün guncellenmistir");

                dataGridView1.DataSource = kullaniciModel.KullaniciOgunYiyecekModeller.ToList();

            }
            else
                MessageBox.Show("Secili Öğün Yok!");



        }

       



    }


   

}
