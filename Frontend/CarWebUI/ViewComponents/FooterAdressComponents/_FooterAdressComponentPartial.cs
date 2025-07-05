using DTO.AboutDtos;
using DTO.FooterAdressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarWebUI.ViewComponents.FooterAdressComponents
{
    public class _FooterAdressComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FooterAdressComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage =await client.GetAsync("https://localhost:7008/api/FooterAdress");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAdressDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
