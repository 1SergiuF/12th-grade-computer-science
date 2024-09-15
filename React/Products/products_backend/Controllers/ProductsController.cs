using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using products_backend.Models;

namespace products_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext _context;

        public ProductsController(ProductsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products.Include(p => p.Orders).ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.Include(p => p.Orders).FirstOrDefaultAsync(p => p.ProductID == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return Ok("Product was added succesfully");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> PutProduct(int id, Product product)
        {
            if (id != product.ProductID)
                return BadRequest();

            if (!ProductExists(id))
                return NotFound();

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(p => p.ProductID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("filtered")]
        public ActionResult<IEnumerable<Product>> GetProductsFiltered([FromQuery] string text)
        {
            var filteredProd = _context.Products.Include(p => p.Orders).Where(p => p.ProductName.StartsWith(text));

            return Ok(filteredProd);
        }

        [HttpGet("sorted")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductsSorted([FromQuery] string sortBy)
        {
            var prod = await _context.Products.Include(p => p.Orders).ToListAsync();
            IEnumerable<Product>? sortedProd = null;

            switch(sortBy)
            {
                case "asc":
                    sortedProd = prod.OrderBy(p => p.ProductName);
                    break;

                case "desc":
                    sortedProd = prod.OrderByDescending(p => p.ProductName);
                    break;

                default:
                    break;
            }

            return Ok(sortedProd);
        }
    }
}
