using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class IProvidersRepository
    {
        //  void Add(ProvidersModel providersModel);
        // void Edit(ProvidersModel providersModel);
        //void Delete(int id);
        //  IEnumerable<ProvidersModel> GetAll();
        //  IEnumerable<ProvidersModel> GetAll(string value);
        internal IEnumerable<ProvidersModel> GetAll()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<ProvidersModel> GetByValue(string searchValue)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<ProvidersModel> GetByValue(Action<object?, EventArgs> searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
