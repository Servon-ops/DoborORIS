using Microsoft.EntityFrameworkCore;
using WEBORIS.Data;
using WEBORIS.Interfaces;
using WEBORIS.Models;

namespace WEBORIS.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _context;

        public ProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool Add(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> GetAllProduct()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ProductModel> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(ProductModel product)
        {
            _context.Update(product);
            return Save();
        }
    }
}
