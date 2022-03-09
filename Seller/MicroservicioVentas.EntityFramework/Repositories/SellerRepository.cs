using MicroservicioVentas.Core.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.EntityFramework.Repositories
{
    public class SellerRepository:Repository<int, Seller>
    {

        public SellerRepository(MicroservicioVentasDataContext context) : base(context)
        {

        }
    }
}
