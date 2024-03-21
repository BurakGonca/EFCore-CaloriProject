using CaloriProject.BLL.Manager.Abstract;
using CaloriProject.BLL.MappingProfile;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Abstract;
using CaloriProject.DAL.Repostory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Manager.Concrete
{
    public class KullaniciManager : Manager<KullaniciModel, Kullanici, KullaniciMapProfile>
    {

        public KullaniciManager()
        {

            _repository = new KullaniciRepostory(new CaloriDBContext());

        }

        public KullaniciModel KullaniciModelBul(string eMail, string sifre)
        {
            IKullaniciRepostory kullaniciRepo = _repository as IKullaniciRepostory;
            Kullanici kullanici = kullaniciRepo.KullaniciBul(eMail,sifre);
            return _mapper.Map<KullaniciModel>(kullanici);

        }

    }
}
