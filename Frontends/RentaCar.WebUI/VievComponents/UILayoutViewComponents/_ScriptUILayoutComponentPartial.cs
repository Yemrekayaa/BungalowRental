using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.VievComponents.UILayoutViewComponents
{
    public class _ScriptUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}