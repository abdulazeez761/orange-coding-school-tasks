using Products.Models;
namespace Products.Repos
{
    public interface IProductsRepo
    {
        public List<Product> GetProducts();
    }
}
