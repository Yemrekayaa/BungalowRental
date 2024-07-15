using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}