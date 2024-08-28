using Microsoft.AspNetCore.Mvc;

namespace bassant_khaled___sun_wed_8_pm_online___mvc2.controllers
{
    public class HomeController : Controller  
        
    {
        //public string index()                                       //actions (public non static methods)

        //{
        //    return "index";

        //}

        //public string aboutus()                                       //actions (public non static methods)

        //{
        //    return "aboutus";

        //}
        //public IActionResult Index()                            //interface (use helper methods)

        //{
        //    return Content("bassant");
        //}
        //public IActionResult aboutus()                          

        //{
        //    return RedirectToRoute("");
        //}

        public IActionResult Index()                            //actions return view 1

        {
            return View();
        }

        public IActionResult AboutUs()                          //return view 2

        {
            return View();
        }

        public IActionResult privacy()                          //return view 2

        {
            return View();
        }




    }
}
