using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.DAL.Repostory.Concrete
{
    public class KullaniciRepostory : Repostory<Kullanici> , IKullaniciRepostory
    {
        public KullaniciRepostory(CaloriDBContext db) : base(db)
        {
        }

        public Kullanici KullaniciBul(string eMail, string sifre)
        {
            return entities.Where(k=> k.EMail == eMail && k.Sifre == sifre).SingleOrDefault();

        }


    }
}
