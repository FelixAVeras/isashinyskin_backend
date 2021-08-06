using ISSB.Web.Models.Reposotories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISSB.Web.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre Producto")]
        public string ProductName { get; set; }

        [Display(Name = "Descripcion Producto")]
        public string ProductDescription { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }

        [Display(Name = "Imagen Producto")]
        public string ImageUrl { get; set; }

        [Display(Name = "Esta Disponible?")]
        public bool IsAvailable { get; set; }

        public double Stock { get; set; }
    }
}
