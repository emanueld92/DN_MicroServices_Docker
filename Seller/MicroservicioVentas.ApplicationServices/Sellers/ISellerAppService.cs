using MicroservicioVentas.Core.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.ApplicationServices.Sellers
{
    public interface ISellerAppService
    {

        Task<List<Seller>> GetSellersAsync();

        Task<int> AddSellerAsync(Seller seller);

        Task DeleteSellerAsync(int sellerId);

        Task<Seller> GetSellerAsync(int sellerId);


        Task EditMemberAsync(Seller seller);



    }
}
