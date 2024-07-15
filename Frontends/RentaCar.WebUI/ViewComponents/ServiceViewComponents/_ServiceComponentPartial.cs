using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.ServiceDtos;

namespace RentaCar.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServiceComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Service");
            if(response.IsSuccessStatusCode){
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}