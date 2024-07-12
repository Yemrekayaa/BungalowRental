using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}