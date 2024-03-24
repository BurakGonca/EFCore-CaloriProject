using CaloriProject.DAL.Context;
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
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string EMail { get; set; }
        public string Sifre { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public List<KullaniciOgunYiyecek> kullaniciOgunYiyecekler { get; set; } //n-n iliski icin


        CaloriDBContext db = new CaloriDBContext();

        public void Update(Kullanici item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Kullanici item)
        {
            db.Kullanicilar.Remove(item);
            db.SaveChanges();
        }


    }
}
