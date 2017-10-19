using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEX.Models;
using DEX.ViewModels;

namespace DEX.Repositories.RepoInterfaces
{
    public interface ICityRepository
    {
        void CreateCity(CityViewModel city);
        void DeleteCity(int cityId);
    }
}
