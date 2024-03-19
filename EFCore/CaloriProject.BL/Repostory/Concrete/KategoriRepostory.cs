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
    public class KategoriRepostory : Repostory<Kategori>
    {
        public KategoriRepostory(CaloriDBContext db) : base(db)
        {
        }


    }
}
