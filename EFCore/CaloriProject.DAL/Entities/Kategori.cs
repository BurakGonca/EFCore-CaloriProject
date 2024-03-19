using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Entities
{
    public class Kategori : Entity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }


        public List<Yiyecek> Yiyecekler { get; set; } //navigation prop.



    }
}
