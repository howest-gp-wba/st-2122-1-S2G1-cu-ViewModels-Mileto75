using cu.ViewModels.Lesvoorbeeld.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace cu.ViewModels.Lesvoorbeeld.ViewComponents
{
    [ViewComponent(Name = "ChuckNorrisQuote")]
    public class ChuckNorrisComponent : ViewComponent
    {
        private ChuckNorrisQuoteViewModel ChuckNorrisQuoteViewModel
            = new ChuckNorrisQuoteViewModel();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //call the api and get the data
            HttpClient httpClient = new HttpClient();
            var request = 
                await httpClient.GetAsync("https://api.chucknorris.io/jokes/random");
            var content = await request.Content.ReadAsStringAsync();
            //turn string Json into viewmodel object
            //use NewtonSoft Json library
            ChuckNorrisQuoteViewModel =
                JsonConvert
                .DeserializeObject<ChuckNorrisQuoteViewModel>(content);
            return View(ChuckNorrisQuoteViewModel);
        }
    }
}
