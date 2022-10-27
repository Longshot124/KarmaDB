using classwork26._10.Models;
using classworktest.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classwork26._10.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var products = _appDbContext.Products.ToList();
            var categories = _appDbContext.Categories.ToList();
            var homeViewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products
            };
            return View(homeViewModel);

        }
    }
}
