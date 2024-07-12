using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}