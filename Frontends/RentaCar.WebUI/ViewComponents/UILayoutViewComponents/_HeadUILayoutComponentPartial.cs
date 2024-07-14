
using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.UILayoutViewComponents
{
    public class _HeadUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}