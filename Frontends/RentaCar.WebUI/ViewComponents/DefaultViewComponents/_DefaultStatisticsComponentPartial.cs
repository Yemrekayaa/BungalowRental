using Microsoft.AspNetCore.Mvc;

namespace RentaCar.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}