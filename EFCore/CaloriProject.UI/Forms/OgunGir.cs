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
        CaloriDBContext Db = new CaloriDBContext();

        private AnaSayfa anaSayfa;

        KullaniciOgunYiyecek secilenOgun;

        private KullaniciOgunYiyecekRepostory koyRepostory;

        public OgunGir(AnaSayfa ana)
        {
            anaSayfa = ana;
            InitializeComponent();

            koyRepostory = new KullaniciOgunYiyecekRepostory(Db);

            dataGridView1.DataSource = Db.KullaniciOgunYiyecek.ToList();

            comboBox1_ogun.DataSource = Db.Ogünler.ToList();
            comboBox3_yiyecek.DataSource = Db.Yiyecekler.ToList();



        }



        private void button4_Click(object sender, EventArgs e)
        {
            anaSayfa.Show();
            this.Hide();

        }

        private void ekle_buton_Click(object sender, EventArgs e)
        {

            KullaniciOgunYiyecek kullaniciOgunYiyecek = new KullaniciOgunYiyecek();


            kullaniciOgunYiyecek.Kullanici = Db.Kullanicilar.FirstOrDefault();


            if (comboBox3_yiyecek.SelectedItem != null)
            {
                kullaniciOgunYiyecek.Yiyecek = (Yiyecek)comboBox3_yiyecek.SelectedItem;
            }
            else
            {
                MessageBox.Show("Lütfen bir yiyecek seçin.");
                return;
            }


            if (comboBox1_ogun.SelectedItem != null)
            {
                kullaniciOgunYiyecek.Ogun = (Ogun)comboBox1_ogun.SelectedItem;
            }
            else
            {
                MessageBox.Show("Lütfen bir öğün seçin.");
                return;
            }

            kullaniciOgunYiyecek.Tarih = dateTimePicker1.Value;

            DialogResult dialog = MessageBox.Show("Öğününüzü eklemek istediğinizden emin misiniz?", "Ekle", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {



                koyRepostory.Add(kullaniciOgunYiyecek);

                MessageBox.Show("Öğün Başarıyla Eklenmiştir!");

                // DataGridView güncellemesi
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Db.KullaniciOgunYiyecek.ToList();
            }
            else
            {
                MessageBox.Show("Öğün Ekleme İptal Edilmiştir.");
            }

            comboBox1_ogun.Items.Clear();
            comboBox3_yiyecek.Items.Clear();

        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                var silinecekOgun = Db.KullaniciOgunYiyecek.FirstOrDefault(k => k.Id == secilenOgun.Id);
                koyRepostory.Remove(silinecekOgun);
                MessageBox.Show("Öğün silinmiştir.");
                dataGridView1.DataSource = Db.KullaniciOgunYiyecek.ToList();

            }
            else
                MessageBox.Show("Secili Öğün Yok!");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (KullaniciOgunYiyecek)dataGridView1.SelectedRows[0].DataBoundItem;
            comboBox1_ogun.Text = secilenOgun.Ogun.OgunAdi;
            comboBox3_yiyecek.Text = secilenOgun.Yiyecek.YiyecekAdi;

        }

        private void guncelle_buton_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {

                var guncellenecekOgun = Db.KullaniciOgunYiyecek.FirstOrDefault(k => k.Id == secilenOgun.Id);

                guncellenecekOgun.UpdatedDate = DateTime.Now;
                guncellenecekOgun.Yiyecek = (Yiyecek)(comboBox3_yiyecek.SelectedItem);
                guncellenecekOgun.Ogun = (Ogun)comboBox1_ogun.SelectedItem;
                guncellenecekOgun.Tarih = dateTimePicker1.Value;

                koyRepostory.Update(guncellenecekOgun);
                MessageBox.Show("Öğün guncellenmistir");

                dataGridView1.DataSource = Db.KullaniciOgunYiyecek.ToList();

            }
            else
                MessageBox.Show("Secili Öğün Yok!");
        }
    }
}
