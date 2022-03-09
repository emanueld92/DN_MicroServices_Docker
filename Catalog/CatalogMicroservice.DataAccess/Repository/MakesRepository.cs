using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.DataAccess.Repository
{
    public class MakesRepository: Repository<int, Make>
    {
        public MakesRepository(CatalogMicroserviceContext context) : base(context)
        {

        }
    }
}
