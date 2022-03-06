using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.Core.Entity
{
    public class Make
    {
        [Key]
        public int IdMake { get; set; }
        [Required]
        [StringLength(20)]
        public string MakeName { get; set; }

        public List<Product> Products { get; set; }

        public Make()
        {
            Products = new List<Product>();
        }

    }
}
