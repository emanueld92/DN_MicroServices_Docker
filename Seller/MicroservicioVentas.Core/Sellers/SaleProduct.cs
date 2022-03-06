
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicioVentas.Core.Sellers
{
    public class SaleProduct
    {
        [Key]
        public int Id { get; set; }

        public int SellerId { get; set; }
        //public int ProductId { get; set; }

        //public Product Product { get; set; }

        public List<Seller> Seller { get; set; }

        public SaleProduct()
        {
            Seller = new List<Seller>();
        }

    }
}
