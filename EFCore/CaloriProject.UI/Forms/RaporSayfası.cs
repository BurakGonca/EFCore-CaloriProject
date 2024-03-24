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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaloriProject.UI.Forms
{

    public partial class RaporSayfası : Form
    {
        KullaniciOgunYiyecekManager kullaniciOgunYiyecekManager = new KullaniciOgunYiyecekManager();
        KategoriManager kategoriManager = new KategoriManager();
        KullaniciManager kullaniciManager = new KullaniciManager();
        OgunManager ogunManager = new OgunManager();
        YiyecekManager yiyecekManager = new YiyecekManager();

        private AnaSayfa anaSayfa;
        private KullaniciModel KullaniciModel;

        





        public RaporSayfası(AnaSayfa ana, KullaniciModel kulanici)
        {

            KullaniciModel = kulanici;
            Program.AktifSayfa = this;
            anaSayfa = ana;
            
            
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.AktifSayfa.Hide();
            anaSayfa.Show();
        }

        private void günSonu_Click(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;


            var gunluktotal = (from koy in kullaniciOgunYiyecekManager.GetAll()
                               join k in kullaniciManager.GetAll() on koy.KullaniciID equals k.Id
                               join yem in yiyecekManager.GetAll() on koy.YiyecekID equals yem.Id
                               join ogun in ogunManager.GetAll() on koy.OgunID equals ogun.Id
                               where k.Id == KullaniciModel.Id
                               where selectedDate == koy.Tarih.Date
                               select new { toplamkalori = yem.Kalori }


                   ).ToList();
            double kalorihesap = gunluktotal.Sum(x => x.toplamkalori);

            lblToplamCalory.Text = kalorihesap.ToString();


            var gunlukKahvalti = (from koy in kullaniciOgunYiyecekManager.GetAll()
                                  join k in kullaniciManager.GetAll() on koy.KullaniciID equals k.Id
                                  join yem in yiyecekManager.GetAll() on koy.YiyecekID equals yem.Id
                                  join ogun in ogunManager.GetAll() on koy.OgunID equals ogun.Id
                                  where k.Id == KullaniciModel.Id
                                  where ogun.Id == 1
                                  where selectedDate == koy.Tarih.Date
                                  select new { toplamKahvaltiKalori = yem.Kalori }


                   ).ToList();
            double kahvaltiKalori = gunlukKahvalti.Sum(x => x.toplamKahvaltiKalori);

            lblKahvaltiKalori.Text = kahvaltiKalori.ToString();



            var gunlukOglen = (from koy in kullaniciOgunYiyecekManager.GetAll()
                               join k in kullaniciManager.GetAll() on koy.KullaniciID equals k.Id
                               join yem in yiyecekManager.GetAll() on koy.YiyecekID equals yem.Id
                               join ogun in ogunManager.GetAll() on koy.OgunID equals ogun.Id
                               where k.Id == KullaniciModel.Id
                               where ogun.Id == 2
                               where selectedDate == koy.Tarih.Date
                               select new { toplamOglenKalori = yem.Kalori }



                   ).ToList();
            double oglenKalori = gunlukOglen.Sum(x => x.toplamOglenKalori);

            lblOglenKalori.Text = oglenKalori.ToString();


            var gunlukAksam = (from koy in kullaniciOgunYiyecekManager.GetAll()
                               join k in kullaniciManager.GetAll() on koy.KullaniciID equals k.Id
                               join yem in yiyecekManager.GetAll() on koy.YiyecekID equals yem.Id
                               join ogun in ogunManager.GetAll() on koy.OgunID equals ogun.Id
                               where k.Id == KullaniciModel.Id
                               where ogun.Id == 3
                               where selectedDate == koy.Tarih.Date
                               select new { toplamAksamKalori = yem.Kalori }


                  ).ToList();
            double aksamKalori = gunlukAksam.Sum(x => x.toplamAksamKalori);

            lblAksamKalori.Text = aksamKalori.ToString();


        }

        private void RaporSayfası_Load(object sender, EventArgs e)
        {



        }

        private void yenile_buton_Click(object sender, EventArgs e)
        {




        }
    }
}
