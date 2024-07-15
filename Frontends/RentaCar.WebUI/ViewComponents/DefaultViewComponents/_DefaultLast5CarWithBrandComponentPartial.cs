
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.CarDtos;

namespace RentaCar.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5CarWithBrandComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultLast5CarWithBrandComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Car/GetLast5CarWithBrand");
            if(response.IsSuccessStatusCode){
                var jsonData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultCarWithBrandDto>>(jsonData);
                return View(result);
            }
            return View();
        }
    }
}