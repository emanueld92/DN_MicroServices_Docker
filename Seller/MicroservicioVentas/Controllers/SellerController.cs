using MicroservicioVentas.ApplicationServices.Sellers;
using MicroservicioVentas.Core.Sellers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroservicioVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerAppService _manager;

        public SellerController(ISellerAppService manager)
        {
            _manager = manager;

        }
        // GET: api/<TestController>
        [HttpGet]
        public async  Task<IEnumerable<Seller>> Get()
        {
            return await _manager.GetSellersAsync();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public async Task <Seller> Get(int id)
        {
            var seller = await _manager.GetSellerAsync(id);

            return seller;
        }

        // POST api/<TestController>
        [HttpPost]
        public async Task Post([FromBody] Seller seller)
        {
            await _manager.AddSellerAsync(seller);

        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Seller seller)
        {
            seller.Id = id;
            await _manager.EditMemberAsync(seller);

        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _manager.DeleteSellerAsync(id);
        }
    }
}
