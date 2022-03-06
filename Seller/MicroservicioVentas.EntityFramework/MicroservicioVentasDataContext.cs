using MicroservicioVentas.Core.Sellers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.EntityFramework
{
    public class MicroservicioVentasDataContext : DbContext
    {

        public MicroservicioVentasDataContext(DbContextOptions<MicroservicioVentasDataContext> options) : base(options)
        {

        }
        public DbSet<Seller> sellers { get; set; }


        public DbSet<SaleProduct> saleProducts { get; set; }


    }
}
