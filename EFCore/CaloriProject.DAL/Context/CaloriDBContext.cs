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
            optionsBuilder.UseSqlServer("server=BURAK;Database=CaloriDB;Trusted_Connection=true;trustservercertificate=true");

        }

        //tablo olusturma islemleri
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogünler { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<KullaniciOgunYiyecek> KullaniciOgunYiyecekler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ogun>().HasData
                (
                    new Ogun() { Id = 1, OgunAdi = "Kahvalti" } ,
                    new Ogun() { Id = 2, OgunAdi = "Ogle" },
                    new Ogun() { Id = 3, OgunAdi = "Aksam" }

                );

            modelBuilder.Entity<Kategori>().HasData
                (
                    new Kategori() { Id = 1, KategoriAdi = "Kahvalti" },
                    new Kategori() { Id = 2, KategoriAdi = "Ara Sicak" },
                    new Kategori() { Id = 3, KategoriAdi = "Aperatifler" },
                    new Kategori() { Id = 4, KategoriAdi = "Corbalar" },
                    new Kategori() { Id = 5, KategoriAdi = "Ana Yemekler" },
                    new Kategori() { Id = 6, KategoriAdi = "Icecekler" },
                    new Kategori() { Id = 7, KategoriAdi = "Tatli" }

                );

            modelBuilder.Entity<Yiyecek>().HasData
                (
                    new Yiyecek() { Id = 1, YiyecekAdi = "Manti" ,Porsiyon =1 , Kalori = 300 , KategoriID = 5  },
                    new Yiyecek() { Id = 2, YiyecekAdi = "Menemen" ,Porsiyon =1 , Kalori = 200 , KategoriID = 1  },
                    new Yiyecek() { Id = 3, YiyecekAdi = "Patates Kızartmasi" ,Porsiyon =2 , Kalori = 300 , KategoriID = 3  },
                    new Yiyecek() { Id = 4, YiyecekAdi = "Adana Kebap" ,Porsiyon =1 , Kalori = 500 , KategoriID = 5  },
                    new Yiyecek() { Id = 5, YiyecekAdi = "Mercimek Corbasi" ,Porsiyon =1 , Kalori = 200 , KategoriID = 4  },
                    new Yiyecek() { Id = 6, YiyecekAdi = "Baklava" ,Porsiyon =1 , Kalori = 400 , KategoriID = 7  },
                    new Yiyecek() { Id = 7, YiyecekAdi = "Su" ,Porsiyon =1 , Kalori = 50 , KategoriID = 6  },
                    new Yiyecek() { Id = 8, YiyecekAdi = "Omlet" ,Porsiyon =1 , Kalori = 200 , KategoriID = 1  },
                    new Yiyecek() { Id = 9, YiyecekAdi = "Yaprak Ciger" ,Porsiyon =1 , Kalori = 400 , KategoriID = 2  },
                    new Yiyecek() { Id = 10, YiyecekAdi = "Sütlü Nuriye" ,Porsiyon =1 , Kalori = 200 , KategoriID = 7  }
                   

                );

        }

    }
}
