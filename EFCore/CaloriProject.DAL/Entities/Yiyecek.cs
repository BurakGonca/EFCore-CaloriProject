using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class Yiyecek : Entity
    {
        
        public int YiyecekID { get; set; }
        public string YiyecekAdi { get; set; }
        public double Porsiyon { get; set; }
        public double Kalori { get; set; }
        public string? Fotograf { get; set; }


       
        public int KategoriID { get; set; } //ForeignKey "kategori-yiyecek >> 1-n"
        public Kategori Kategori { get; set; } //Navigation Prop.


     



    }
}
