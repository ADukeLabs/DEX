using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Dex_API.Models.DomainModels;
using DEX_API.ViewModels;
using Dex_API_2.Models.ModelFactories.Interfaces;
using Microsoft.Ajax.Utilities;

namespace Dex_API_2.Models.ModelFactories
{
    public class ModelFactory : IModelFactory
    {
        public IList<CityViewModel> ToViewModelList(IList<City> rawCityData)
        {
            var cities = new List<CityViewModel>();
            rawCityData.ForEach(c => cities.Add(Mapper.Map<CityViewModel>(c)));
            return cities;
        }
    }
}