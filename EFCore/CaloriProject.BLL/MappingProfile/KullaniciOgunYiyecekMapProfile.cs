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
    public class KullaniciOgunYiyecekMapProfile : Profile
    {
        public KullaniciOgunYiyecekMapProfile()
        {
            CreateMap<KullaniciModel, Kullanici>().
            ForMember(a => a.kullaniciOgunYiyecekler, b => b.MapFrom(src => src.KullaniciOgunYiyecekModeller)).ReverseMap();

            CreateMap<OgunModel, Ogun>().
            ForMember(a => a.kullaniciOgunYiyecekler, b => b.MapFrom(src => src.KullaniciOgunYiyecekModeller)).ReverseMap();

            CreateMap<YiyecekModel, Yiyecek>().
            ForMember(a => a.kullaniciOgunYiyecekler, b => b.MapFrom(src => src.KullaniciOgunYiyecekModeller)).ReverseMap();

            CreateMap<KullaniciOgunYiyecekModel, KullaniciOgunYiyecek>().
                 ReverseMap();

        }
    }
}
