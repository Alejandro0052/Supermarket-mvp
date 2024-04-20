using Supermarket_mvp.Models;

namespace Supermarket_mvp._Repositories
{
    internal interface IProductRepository
    {
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string searchValue);
    }
}