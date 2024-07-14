using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.AboutViewComponents
{
    public class _BecomeDriverComponentPartial: ViewComponent
    {
        
        public IViewComponentResult Invoke(){
            return View();
        }

    }
}