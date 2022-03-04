using MicroservicioVentas.Core.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.ApplicationServices.ProductSales
{
    public interface IProductSaleAppService
    {
        Task<List<SaleProduct>> GetSaleProductsAsync();

        Task<int> AddSaleProductAsync(SaleProduct saleProduct);

        Task DeleteSaleProductAsync(int saleProductId);

        Task<SaleProduct> GetSaleProductAsync(int saleProductId);


        Task EditSaleProductAsync(SaleProduct saleProduct);



    }
}
