
using MicroservicioVentas.ApplicationServices.ProductSales;
using MicroservicioVentas.Core.Sellers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MicroservicioVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSaleController : ControllerBase
    {
        private readonly IProductSaleAppService _manager;

        public ProductSaleController(IProductSaleAppService manger)
        {
            _manager = manger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SaleProduct>> GetSeleProductAsync(int id)
        {
            var product = await _manager.GetSaleProductAsync.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteSeleProductAsync(int id)
        {
            var product = _manager.DeleteSaleProductAsync.FindAsync(id);

        }

        [HttpPost]
        public async Task<ActionResult<SaleProduct>> AddSaleProductAsync(SaleProduct  saleProduct)
        {
            _manager.AddSaleProductAsync(saleProduct);
            await _manager.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }


    }
}
