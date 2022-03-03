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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;
        public CategoryController(ICategoryAppService categoryAppService)=>_categoryAppService=categoryAppService;

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryAppService.GetCategoryAllAsync();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<Category> Get(int id)
        {


            return await _categoryAppService.GetCategoryAsync(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task Post([FromBody] Category value)
        {
            await _categoryAppService.AddCategoryAsync(value);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Category value)
        {
            value.IdCategory = id;
            await _categoryAppService.EditCategoryAsync(value);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _categoryAppService.DeleteCategoryAsync(id);
        }
    }
}
