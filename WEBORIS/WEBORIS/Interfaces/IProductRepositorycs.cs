using WEBORIS.Models;

namespace WEBORIS.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductModel>> GetAllProduct();
        Task<ProductModel> GetProductById(int id);
        bool Add(ProductModel product);
        bool Update(ProductModel product);
        bool Delete(ProductModel product);
        bool Save();
    }
}
