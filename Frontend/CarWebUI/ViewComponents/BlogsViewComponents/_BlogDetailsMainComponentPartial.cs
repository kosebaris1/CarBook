using DTO.BlogDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsMainComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
         var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7008/api/Blog/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultGetBlogByIdDto>(jsonData);
                return View(values);
            }
            else
            {
                return View(Enumerable.Empty<ResultGetBlogByIdDto>());
            }

        }
    }
}
