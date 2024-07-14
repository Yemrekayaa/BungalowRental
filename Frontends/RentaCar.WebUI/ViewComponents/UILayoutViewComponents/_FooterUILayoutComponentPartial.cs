
using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}