using cu.ViewModels.Lesvoorbeeld.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Games.Core;

namespace cu.ViewModels.Lesvoorbeeld.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameRepository _gameRepository;

        public GamesController()
        {
            _gameRepository = new GameRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetGames()
        {
            //declare view model
            GamesGetGamesViewModel gamesgetGamesViewModel
                = new GamesGetGamesViewModel();
            //using select
            
           // getGamesViewModel.Titles = new List<string>();
           // //get games from repo/database
           //foreach(var game in _gameRepository.GetGames())
           // {
           //     getGamesViewModel.Titles.Add(game?.Title ?? "<NoTitle>");
           // }
            ViewBag.PageTitle = "Our Games";
            //send to the view
            return View(gamesgetGamesViewModel);
        }

        public IActionResult GameInfo(int id)
        {
            return View();
        }
    }
}
