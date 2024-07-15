
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.BannerDtos;

namespace RentaCar.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverUILayoutComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultCoverUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Banner");
            if(response.IsSuccessStatusCode){
                var jsonData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultBannerDto>>(jsonData);
                return View(result);
            }
            return View();
        }
    }
}