using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dex_API.Models.DomainModels;
using DEX_Api.ViewModels;

namespace Dex_API.Factories.Interfaces
{
    public interface IModelFactory
    {
        List<CityViewModel> CityToCityViewModel(IList<City> cities);
    }
}
