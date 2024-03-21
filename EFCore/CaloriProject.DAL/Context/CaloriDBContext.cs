using CaloriProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Context
{
    public class CaloriDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Pull'layan server'ı ve Database'i değiştirmeyi unutmasın.
            optionsBuilder.UseSqlServer("server=KASKADE;Database=loginEkrani_c#;Trusted_Connection=true;trustservercertificate=true");

        }

        //tablo olusturma islemleri
        public DbSet<Kategori> Kategoriler { get; set; } 
        public DbSet<Kullanici> Kullanicilar { get; set; } 
        public DbSet<Ogun> Ogünler { get; set; } 
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<KullaniciOgunYiyecek> KullaniciOgunYiyecekler { get; set; }




    }
}
