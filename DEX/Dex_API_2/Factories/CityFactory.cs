using Dex_API.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Dex_API_2.Factories.Interfaces;
using DEX_Api.ViewModels;
using WebGrease.Css.Extensions;

namespace Dex_API_2.Factories
{
    public class ModelFactory : IModelFactory
    {
        public List<CityViewModel> CityToCityViewModel(IList<City> rawCityData)
        {
            var cities = new List<CityViewModel>();
            rawCityData.ForEach(c => cities.Add(Mapper.Map<CityViewModel>(c)));
            return cities;
        }
    }
}