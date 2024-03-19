using CaloriProject.DAL.Enums;
using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class Kullanici : Entity
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }


        public List<Ogun> Ogunler { get; set; } //navigation prop.
        public List<Yiyecek> Yiyecekler { get; set; } //navigation prop.






    }
}
