using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    //we use the name 'Home"Controller and 'Index' because they are looked for by default
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello, from the HomeController.";
        //}

        //public IActionResult Index()
        //{
        //    var restaurant = new Restaurant
        //    {
        //        Id = 1,
        //        Name = "Test Name"
        //    };

        //    return new ObjectResult(restaurant);
        //}

        public IActionResult Index()
        {
            var restaurant = new Restaurant
            {
                Id = 1,
                Name = "Test Name"
            };

            return View(restaurant);
        }
    }
}
