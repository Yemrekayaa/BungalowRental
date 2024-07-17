using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Services";
            ViewBag.v2 = "Our Services";
            return View();
        }


    }
}