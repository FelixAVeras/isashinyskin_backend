using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISSB.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Nombre Producto")]
        public string ProductName { get; set; }

        [Display(Name = "Descripcion Producto")]
        public string ProductDescription { get; set; }
        
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        public double Stock { get; set; }
    }
}
