using MicroservicioVentas.Core.Sellers;
using MicroservicioVentas.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.ApplicationServices.Sellers
{
    public class SellerAppService : ISellerAppService
    {
        private readonly IRepository<int, Seller> _repository;


        public SellerAppService (IRepository <int , Seller> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddSellerAsync(Seller seller)
        {
            await _repository.AddAsync(seller);
            return seller.Id;
        }

        public async Task DeleteSellerAsync(int sellerId)
        {
            await _repository.DeleteAsync(sellerId);
        }

        public async Task EditMemberAsync(Seller seller)
        {
            await _repository.UpdateAsync(seller);
        }

        public async Task<Seller> GetSellerAsync(int sellerId)
        {
            return await _repository.GetAsync(sellerId);
        }

        public async Task<List<Seller>> GetSellersAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }
    }
}
