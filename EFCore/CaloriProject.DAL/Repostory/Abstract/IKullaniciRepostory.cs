using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Repostory.Abstract
{
    public interface IKullaniciRepostory
    {
        Kullanici KullaniciBul(string eMail, string sifre);
      



    }
}
