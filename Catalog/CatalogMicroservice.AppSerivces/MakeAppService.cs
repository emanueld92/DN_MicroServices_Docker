
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
        private readonly IRepository<int, Make> _repository;
        public MakeAppService(IRepository<int, Make> repository)
        {
            _repository = repository;
        }


        //Insert
        public async Task<int> AddMakeAsync(Make make)
        {
            await _repository.AddAsync(make);

            return make.IdMake;
        }

        //Delte
        public async Task DeleteMakeAsync(int makeId)
        {
            await _repository.DeleteAsync(makeId);
        }
        
        //Update

        public async Task EditMakeAsync(Make make)
        {
            await _repository.UpdateAsync(make);

        }

        //Get all
        public async Task<IList<Make>> GetMakeAllAsync()
        {
            return await _repository.GetAll();
        }
        //Get Id
        public async Task<Make> GetMakeAsync(int makeId)
        {
            return await _repository.GetAsync(makeId);

            
        }


    }
}
