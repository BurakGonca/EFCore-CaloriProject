using CaloriProject.BLL.Manager.Abstract;
using CaloriProject.BLL.MappingProfile;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Context;
using CaloriProject.DAL.Entities;
using CaloriProject.DAL.Repostory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.Manager.Concrete
{
    public class YiyecekManager : Manager<YiyecekModel, Yiyecek, YiyecekMapProfile>
    {
        public YiyecekManager()
        {

            _repository = new YiyecekRepostory(new CaloriDBContext());


        }
    }
}
