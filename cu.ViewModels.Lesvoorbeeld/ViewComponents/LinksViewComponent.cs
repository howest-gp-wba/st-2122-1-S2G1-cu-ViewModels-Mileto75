using cu.ViewModels.Lesvoorbeeld.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cu.ViewModels.Lesvoorbeeld.ViewComponents
{
    [ViewComponent(Name = "LinksComponent")]
    public class LinksViewComponent : ViewComponent
    {
        
        private readonly List<LinkViewComponentViewModel>
            _linksViewComponentViewModel = new List<LinkViewComponentViewModel>();

      
        public IViewComponentResult Invoke()
        {
            _linksViewComponentViewModel.Add(new LinkViewComponentViewModel
            {
                Url = "http://www.gazetta.it",
                Name = "Gazzeta"
            });
            _linksViewComponentViewModel.Add(new LinkViewComponentViewModel
            {
                Url = "http://www.github.com",
                Name = "Github"
            });
            return View(_linksViewComponentViewModel);
        }
    }
}
