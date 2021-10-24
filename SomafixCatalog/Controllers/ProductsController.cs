using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomafixCatalog.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SomafixCatalog.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;

        public ProductsController(ApplicationDbContext context)
        {
            this.productRepository = new ProductRepository(context);
        }
        public ProductsController(IProductRepository repository)
        {
            this.productRepository = repository;
        }

        public IActionResult Index()
        {
            
            return View();
        }
    }
}
