using System;
namespace OdeToFood.Controllers
{
    public class HomeController //we use the name 'Home"Controller and 'Index' because they are looked for by default
    {
        public string Index()
        {
            return "Hello, from the HomeController.";
        }
    }
}
