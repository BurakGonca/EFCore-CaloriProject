using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class KategoriModel
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<YiyecekModel> Yiyecekler { get; set; } 


    }
}
