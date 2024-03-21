using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class KullaniciOgunYiyecekModel
    {
        public int KullaniciID { get; set; }
        public KullaniciModel KullaniciModeller { get; set; }

        public int YiyecekID { get; set; }
        public YiyecekModel YiyecekModeller { get; set; }

        public int OgunID { get; set; }
        public OgunModel OgunModeller { get; set; }

        public DateTime Tarih { get; set; }
        public double Porsiyon { get; set; }



    }
}
