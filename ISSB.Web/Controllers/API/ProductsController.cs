using ISSB.Web.Models;
using ISSB.Web.Models.Data;
using ISSB.Web.Models.Reposotories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSB.Web.Controllers.API
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        //private readonly IProductRepository _productRepository;
        private readonly DataContext _context;

        public ProductsController(/*IProductRepository productRepository,*/ DataContext context)
        {
            //_productRepository = productRepository;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
    }
}
