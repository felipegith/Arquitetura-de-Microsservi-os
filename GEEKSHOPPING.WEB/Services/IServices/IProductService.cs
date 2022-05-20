using GEEKSHOPPING.WEB.Models;

namespace GEEKSHOPPING.WEB.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProduct();
        Task <ProductModel> FindProductById(long id);
        Task <ProductModel> CreateProduct(ProductModel model);
        Task <ProductModel> UpdateProduct(ProductModel model);
        Task <bool> DeleteProductById(long id);
    }
}
