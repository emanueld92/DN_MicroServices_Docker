using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public interface ICategoryAppService
    {
        //Get all
        Task<IList<Category>> GetCategoryAllAsync();
        //Create
        Task <int> AddCategoryAsync(Category category);
        //Delete
        Task DeleteCategoryAsync(int categoryId);
        //Get ID
        Task<Category> GetCategoryAsync(int categoryId);
        //Update
        Task EditCategoryAsync(Category category);

    }
}
