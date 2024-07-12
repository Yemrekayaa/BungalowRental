using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}