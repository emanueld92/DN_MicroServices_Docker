
using CatalogMicroservice.Core.Entity;
using CatalogMicroservice.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public class MakeAppService : IMakeAppService
    {
        private readonly CatalogMicroserviceContext _dataContext;
        public MakeAppService(CatalogMicroserviceContext dataContext) => _dataContext = dataContext; 


        //Insert
        public async Task AddMakeAsync(Make make)
        {
            await _dataContext.Makes.AddAsync(make);
            await _dataContext.SaveChangesAsync();
        }

        //Delte
        public async Task DeleteMakeAsync(int makeId)
        {
            var entity = await _dataContext.Makes.FindAsync(makeId);
             _dataContext.Makes.Remove(entity);
            await _dataContext.SaveChangesAsync();
        }
        
        //Update

        public async Task EditMakeAsync(Make make)
        {
            var entity = await _dataContext.Makes.FindAsync(make.IdMake);
            entity.MakeName = make.MakeName;
            await _dataContext.SaveChangesAsync();

        }

        //Get all
        public async Task<IList<Make>> GetMakeAllAsync()
        {
            var result = await _dataContext.Makes.ToListAsync();
            return result;
        }
        //Get Id
        public async Task<Make> GetMakeAsync(int makeId)
        {
            var entity = await _dataContext.Makes.FindAsync(makeId);

            return entity;
        }


    }
}
