using Dex_API.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEX_API.Repositories.Interfaces
{
    public interface ICityRepository
    {
        IList<City> GetCities();
        void CreateCity(string name);
        void DeleteCity(int cityId);
    }
}
