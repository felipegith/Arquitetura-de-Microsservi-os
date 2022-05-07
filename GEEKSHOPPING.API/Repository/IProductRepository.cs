using GEEKSHOPPING.API.Data.VO;

namespace GEEKSHOPPING.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task <ProductVO> FindById(long id);
        Task <ProductVO> Create(ProductVO model);
        Task <ProductVO> Update(ProductVO model);
        Task<bool> Delete(long id);
    }
}
