using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class YiyecekModel
    {
        public int Id { get; set; }
        public string YiyecekAdi { get; set; }
        public double Porsiyon { get; set; }
        public double Kalori { get; set; }
        public string? Fotograf { get; set; }



        public int KategoriID { get; set; } //ForeignKey "kategori-yiyecek >> 1-n"
        public KategoriModel KategoriModel { get; set; } //Navigation Prop.

       
        public List<KullaniciOgunYiyecekModel> KullaniciOgunYiyecekModeller { get; set; }



    }
}
