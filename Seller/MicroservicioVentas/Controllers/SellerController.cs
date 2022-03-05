using MicroservicioVentas.ApplicationServices.Sellers;
using MicroservicioVentas.Core.Sellers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Seller>>> Get()
        {
            return await _manager.GetSellersAsync();
            
        }

        [HttpGet("id")]
        public  async Task<ActionResult<Seller>> Get(int id)
        {
            var seller = await _manager.GetSellerAsync(id);

            return seller; 

        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
           await _manager.DeleteSellerAsync(id);

            return NoContent();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Put(  Seller seller)
        {
            await _manager.EditMemberAsync(seller);
            return NoContent();

        }

    }
}
