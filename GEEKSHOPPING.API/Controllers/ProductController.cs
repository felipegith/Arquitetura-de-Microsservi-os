using GEEKSHOPPING.API.Data.VO;
using GEEKSHOPPING.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GEEKSHOPPING.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var product = await _productRepository.FindAll();
            
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _productRepository.FindById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO model)
        {
            if (model == null)
                return BadRequest();

            var product = await _productRepository.Create(model);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO model)
        {
            if (model == null)
                return BadRequest();

            var product = await _productRepository.Update(model);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var delete = await _productRepository.Delete(id);

            if (!delete)
                return BadRequest();

            return Ok(delete);
        }
    }
}
