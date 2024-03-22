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
                    new Kategori() { Id = 6, KategoriAdi = "Icecekler" }

                );


        }

    }
}
