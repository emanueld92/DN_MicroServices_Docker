using CatalogMicroservice.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.DataAccess 

{
    public class CatalogMicroserviceContext : DbContext
    {



        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Make> Makes { get; set; }

        public CatalogMicroserviceContext(DbContextOptions<CatalogMicroserviceContext> options) : base(options)
        {

        }
    }
}
