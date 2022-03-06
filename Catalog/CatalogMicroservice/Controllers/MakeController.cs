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
    public class MakeController : ControllerBase
    {

        private readonly IMakeAppService _makeAppService;
        public MakeController(IMakeAppService makeAppService)=>_makeAppService=makeAppService;

        // GET: api/<MakeController>
        [HttpGet]
        public async Task<IEnumerable<Make>> Get()
        {
            return await _makeAppService.GetMakeAllAsync();
        }

        // GET api/<MakeController>/5
        [HttpGet("{id}")]
        public async Task<Make> Get(int id)
        {
            return await _makeAppService.GetMakeAsync(id);
        }

        // POST api/<MakeController>
        [HttpPost]
        public async Task Post([FromBody] Make value)
        {
            await _makeAppService.AddMakeAsync(value);

        }

        // PUT api/<MakeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Make value)
        {

            value.IdMake=id;
            await _makeAppService.EditMakeAsync(value); 
        }

        // DELETE api/<MakeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _makeAppService.DeleteMakeAsync(id);
        }
    }
}
