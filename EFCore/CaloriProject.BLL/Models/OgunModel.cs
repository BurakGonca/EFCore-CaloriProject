using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Models
{
    public class OgunModel
    {
        public int Id { get; set; }
        public string OgunAd { get; set; }

        public List<KullaniciOgunYiyecekModel> KullaniciOgunYiyecekModeller { get; set; }

        public override string ToString()
        {
            return OgunAd;
        }


    }
}
