using AutoMapper;
using CaloriProject.BLL.Models;
using CaloriProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriProject.BLL.MappingProfile
{
    public class KategoriMapProfile : Profile
    {

        public KategoriMapProfile()
        {
            CreateMap<KategoriModel, Kategori>().
		   ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).ReverseMap();


        }
    }
}
