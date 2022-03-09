using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.DataAccess.Repository
{
    public class CategoriesRepository : Repository<int, Category>
    {

        public CategoriesRepository(CatalogMicroserviceContext context):base(context)
        {
        }
    }
}
