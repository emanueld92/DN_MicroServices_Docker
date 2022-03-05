using MicroservicioVentas.ApplicationServices.ProductSales;
using MicroservicioVentas.Core.Sellers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicioVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleProductController : ControllerBase
    {
        private readonly IProductSaleAppService _manager;

        public SaleProductController(IProductSaleAppService manager)
        {
            _manager = manager;

        }
        // GET: api/<SaleProductController>
        [HttpGet]
        public async Task<IEnumerable<SaleProduct>> Get()
        {
            return _manager.GetSaleProductsAsync();
        }

        // GET api/<SaleProductController>/5
        [HttpGet("{id}")]
        public async Task< SaleProduct> Get(int id)
        {
            return _manager.GetSaleProductAsync(id);
        }

        // POST api/<SaleProductController>
        [HttpPost]
        public async Task Post([FromBody] SaleProduct saleProduct)
        {
            await _manager.AddSaleProductAsync(saleProduct);
        }

        // PUT api/<SaleProductController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] SaleProduct  saleProduct)
        {
            saleProduct.Id = id;
            await _manager.EditSaleProductAsync(saleProduct);
        }

        // DELETE api/<SaleProductController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteSaleProductAsync(id);
        }
    }
}
