using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.Core.Entity
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        [StringLength(20)]


        public string NameProduct { get; set; }


        [Required]
        public Make Make { get; set; }
        
        [Required]
        public Category Category { get; set; }

    }
}
