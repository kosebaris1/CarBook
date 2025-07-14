using DTO.AboutDtos;
using DTO.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsRecentBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsRecentBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7008/api/Blog/GetLast3BlogsWithAuthor");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthors>>(jsonData);
                return View(values);
            }
            else
            {
                // Handle error or return an empty list
                return View(Enumerable.Empty<ResultLast3BlogsWithAuthors>());
            }
        }
    }
 
}
