using AutoMapper;
using AutoMapper.EntityFramework;
using AutoMapper.EquivalencyExpression;
using Dex_API.Models.DomainModels;
using DEX_Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API_2.Mapping
{
    public static class AutoMapperConfiguration
    {


        public static void Configure()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.AddCollectionMappers();
            });

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityViewModel>()
                    .ForMember(s => s.Companies, d => d.Ignore());
                cfg.CreateMap<Company, CompanyViewModel>();
            });
        }
    }
}