using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class KullaniciModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public List<KullaniciOgunYiyecekModel> KullaniciOgunYiyecekModeller { get; set; } //n-n iliski icin


    }
}
