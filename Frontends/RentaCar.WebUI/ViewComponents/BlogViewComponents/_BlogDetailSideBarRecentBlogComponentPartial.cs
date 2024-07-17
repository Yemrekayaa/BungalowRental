using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.BlogDtos;

namespace RentaCar.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailSideBarRecentBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailSideBarRecentBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Blog/GetLast3BlogWithAuthor");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<ResultLast3BlogWithAuthorDto>>(jsonData);
                return View(result);
            }
            return View();
        }
    }
}