using MicroservicioVentas.Core.Sellers;
using MicroservicioVentas.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.ApplicationServices.ProductSales
{
    public class ProductSaleAppService : IProductSaleAppService
    {
        private readonly IRepository<int, SaleProduct> _repository;

        public ProductSaleAppService(IRepository<int, SaleProduct> repository)
        {
            _repository = repository;

        }

        public async Task<int> AddSaleProductAsync(SaleProduct saleProduct)
        {
            await _repository.AddAsync(saleProduct);
            return saleProduct.Id;
        }

        public async Task DeleteSaleProductAsync(int saleProductId)
        {
            await _repository.DeleteAsync(saleProductId);
        }

        public async Task EditSaleProductAsync(SaleProduct saleProduct)
        {
            await _repository.UpdateAsync(saleProduct);
        }

        public Task<SaleProduct> GetSaleProductAsync(int saleProductId)
        {
            return _repository.GetAsync(saleProductId);
        }

        public async Task<List<SaleProduct>> GetSaleProductsAsync()
        {
            return await _repository.GetAllAsync().ToListAsync();
        }
    }
}
