using AutoMapper;
using Dex_API.Models.DomainModels;
using DEX_Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API_2.Mapping.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<City, CityViewModel>();
        }
    }
}