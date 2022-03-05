using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.Core.Entity
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        [StringLength(20)]
        public string NameCategory { get; set; }


        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }

    }
}
