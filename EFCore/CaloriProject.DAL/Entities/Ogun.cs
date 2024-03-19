using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class Ogun : Entity
    {
        public int OgunID { get; set; }
        public string OgunAdi { get; set; }



        public int KullaniciID { get; set; } //ForeignKey  "kullanici-ogün >> 1-n"
        public Kullanici Kullanici { get; set; } //Navigation Prop.


        public List<Yiyecek> Yiyecekler { get; set; } //navigation prop.  "ogün-yiyecek >> n-n"



    }
}
