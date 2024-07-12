using Microsoft.AspNetCore.Mvc;


namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class UILayoutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}