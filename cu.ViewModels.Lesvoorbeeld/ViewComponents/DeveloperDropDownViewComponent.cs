using cu.ViewModels.Lesvoorbeeld.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Games.Core;

namespace cu.ViewModels.Lesvoorbeeld.ViewComponents
{
    [ViewComponent(Name = "DeveloperDropDown")]
    public class DeveloperDropDownViewComponent : ViewComponent
    {
        private readonly DeveloperRepository _developerRepository
            = new DeveloperRepository();
        public IViewComponentResult Invoke()
        {
            //declare the viewmodel and add developers
            IEnumerable<DeveloperDropDownViewModel>
                developerDropDownViewModel = _developerRepository
                .GetDevelopers()
                .Select(d => new DeveloperDropDownViewModel
                {
                    Id = d?.Id ?? 0,
                    Name = d?.Name ?? "<NoName>"
                });
            //pass the to the viewmodel
            return View(developerDropDownViewModel);
        }

    }
}
