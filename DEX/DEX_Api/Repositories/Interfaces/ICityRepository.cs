using DEX_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEX_Api.Repositories.Interfaces
{
    public interface ICityRepository
    {
        void CreateCity(string name);
        void DeleteCity(int cityId);
    }
}
