using CaloriProject.DAL.Repostory.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class KullaniciOgunYiyecek : Entity
    {
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; } 

        public int YiyecekID { get; set; }
        public Yiyecek Yiyecek { get; set; }

        public int OgunID { get; set; }
        public Ogun Ogun { get; set; }

        public DateTime Tarih { get; set; }
        public double Porsiyon { get; set; }



    }
}
