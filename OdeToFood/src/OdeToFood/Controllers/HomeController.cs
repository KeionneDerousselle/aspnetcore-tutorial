using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    //we use the name 'Home"Controller and 'Index' because they are looked for by default
    public class HomeController : Controller
    {
        private readonly IRestaurantData _data;

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

        //public IActionResult Index()
        //{
        //    var restaurant = new Restaurant
        //    {
        //        Id = 1,
        //        Name = "Test Name"
        //    };

        //    return View(restaurant);
        //}

        public HomeController(IRestaurantData data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View(_data.GetAll());
        }
    }
}
