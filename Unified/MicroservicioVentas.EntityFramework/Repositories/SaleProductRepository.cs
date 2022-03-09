using MicroservicioVentas.Core.Sellers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.EntityFramework.Repositories
{
    public class SaleProductRepository : Repository<int, SaleProduct>
    {

        public SaleProductRepository(MicroservicioVentasDataContext context) : base(context)
        {

        }
    }
}
