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
        
        public string OgunAd { get; set; }

        public List<KullaniciOgunYiyecek> kullaniciOgunYiyecekler { get; set; } //n-n iliski icin

        public override string ToString()
        {
            return OgunAd; 
        }

    }
}
