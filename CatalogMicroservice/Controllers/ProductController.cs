using CatalogMicroservice.AppSerivces;
using CatalogMicroservice.Core.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatalogMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService){
            _productAppService = productAppService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {

            return await _productAppService.GetProductAllAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {

            return await _productAppService.GetProductAsync(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task Post([FromBody] Product value)
        {
            
            await _productAppService.AddProductAsync(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Product value)
        {
            value.IdProduct = id;
            await _productAppService.EditProductAsync(value);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productAppService.DeleteProductAsync(id);
        }
    }
}
