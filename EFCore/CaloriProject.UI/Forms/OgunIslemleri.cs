using CaloriProject.BLL.Manager.Concrete;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Concrete;
using CaloriProject.UI.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Platforms.Features.WinFormsLegacyWebUi;
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
        KullaniciManager KullaniciManager = new KullaniciManager();
        OgunManager OgunManager = new OgunManager();
        KullaniciOgunYiyecekModel KullaniciOgunYiyecekModelSecilen = new KullaniciOgunYiyecekModel();
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

            YemekGetir();


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


                YemekGetir();




            }
            else
            {
                MessageBox.Show("Öğün Ekleme İptal Edilmiştir.");
            }






        }

        private void sil_buton_Click(object sender, EventArgs e)
        {


            if (KullaniciOgunYiyecekModelSecilen != null)
            {
                kullaniciOgunYiyecekManager.Remove(KullaniciOgunYiyecekModelSecilen);

                MessageBox.Show("Öğün silinmiştir.");

                YemekGetir();
            }
            else
                MessageBox.Show("Secili Öğün Yok!");

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            if (KullaniciOgunYiyecekModelSecilen != null)
            {



                KullaniciOgunYiyecekModelSecilen.KullaniciID = kullaniciModel.Id;

                KullaniciOgunYiyecekModelSecilen.YiyecekID = ((YiyecekModel)(comboBox3_yiyecek.SelectedItem)).Id;
                KullaniciOgunYiyecekModelSecilen.OgunID = ((Ogun)comboBox1_ogun.SelectedItem).Id;
                KullaniciOgunYiyecekModelSecilen.Tarih = dateTimePicker1.Value;
                kullaniciOgunYiyecekManager.Update(KullaniciOgunYiyecekModelSecilen);


                MessageBox.Show("Öğün guncellenmistir");


                YemekGetir();
            }
            else
                MessageBox.Show("Secili Öğün Yok!");



        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var secilenOgun1 = (YemekView)dataGridView1.SelectedRows[0].DataBoundItem;

            KullaniciOgunYiyecekModelSecilen = kullaniciOgunYiyecekManager.Search((x => x.Id == secilenOgun1.KoyId)).FirstOrDefault();

        }



        public object YemekGetir()
        {
            var yemekListesi = (from koy in kullaniciOgunYiyecekManager.GetAll()
                                join k in KullaniciManager.GetAll() on koy.KullaniciID equals k.Id
                                join yem in YiyecekManager.GetAll() on koy.YiyecekID equals yem.Id
                                join ogun in OgunManager.GetAll() on koy.OgunID equals ogun.Id
                                where k.Id == kullaniciModel.Id

                                group koy by new
                                {
                                    yem.YiyecekAdi,
                                    yem.Kalori,
                                    ogun.OgunAd,
                                    koy.Tarih,
                                    koy.Id
                                }
                                           into gcs
                                select new YemekView { yemekAdi = gcs.Key.YiyecekAdi, toplamKalori = gcs.Key.Kalori, ogunAdi = gcs.Key.OgunAd, tarih = gcs.Key.Tarih, KoyId = gcs.Key.Id }
                                    ).ToList();


            dataGridView1.DataSource = yemekListesi;

            dataGridView1.Columns["KoyId"].Visible = false;

            return dataGridView1.DataSource;


        }






    }




}
