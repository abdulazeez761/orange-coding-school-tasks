using Products.Context;
using Products.Models;

namespace Products.Repos
{

    public class ProductRepo : IProductsRepo
    {
        private readonly ShopContext _context;
        public ProductRepo(ShopContext context)
        {
            _context = context; ;
        }

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = (from ProductsObject in _context.Products select ProductsObject).ToList();
                return products;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new List<Product>();

            }

        }
    }
}
