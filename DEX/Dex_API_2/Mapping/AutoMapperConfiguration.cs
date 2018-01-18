using AutoMapper;
using AutoMapper.EntityFramework;
using AutoMapper.EquivalencyExpression;
using Dex_API.Models.DomainModels;
using Dex_API.ViewModels;
using DEX_Api.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API_2.Mapping
{
    public static class AutoMapperConfiguration
    {

        public static void Configure()
        {
            Mapper.Initialize(cfg => { cfg.AddCollectionMappers();});

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityViewModel>();
                cfg.CreateMap<Company, CompanyViewModel>();
                cfg.CreateMap<Contact, ContactViewModel>();
            });
        }
    }
}