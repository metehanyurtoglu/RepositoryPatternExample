using AutoMapper;
using Domain.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
        }
    }
}
