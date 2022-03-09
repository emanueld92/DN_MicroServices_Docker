using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public interface IMakeAppService
    {
        //Get all
        Task<IList<Make>> GetMakeAllAsync();
        //Create
        Task <int>AddMakeAsync(Make make);
        //Delete
        Task DeleteMakeAsync(int makeId);
        //Get ID
        Task<Make> GetMakeAsync(int makeId);
        //Update
        Task EditMakeAsync(Make make);
    }
}
