using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEX_API.ViewModels;
using Dex_API.Models.DomainModels;

namespace Dex_API_2.Models.ModelFactories.Interfaces
{
    public interface IModelFactory
    {
        IList<CityViewModel> ToViewModelList(IList<City> cities);
    }
}
