using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using products_backend.Models;

namespace products_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ProductsDbContext _context;

        public OrdersController(ProductsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return Ok("Order was added succesfully");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Order>> PutOtrder(int id, Order order)
        {
            if (id != order.OrderID)
                return BadRequest();

            if (!OrderExists(id))
                return NotFound();

            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(o => o.OrderID == id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == id);
            if (order == null) return NotFound();

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("filtered")]
        public ActionResult<IEnumerable<Product>> GetOrdersFiltered([FromQuery] string text)
        {
            var filteredOrders = _context.Orders.Where(o => o.ConsigneeName.StartsWith(text));

            return Ok(filteredOrders);
        }

        [HttpGet("sorted")]
        public async Task<ActionResult<IEnumerable<Product>>> GetOrdersSorted([FromQuery] string sortBy)
        {
            var ord = await _context.Orders.ToListAsync();
            IEnumerable<Order>? sortedOrd = null;

            switch (sortBy)
            {
                case "asc":
                    sortedOrd = ord.OrderBy(o => o.ConsigneeName);
                    break;

                case "desc":
                    sortedOrd = ord.OrderByDescending(o => o.ConsigneeName);
                    break;

                default:
                    break;
            }

            return Ok(sortedOrd);
        }
    }
}
