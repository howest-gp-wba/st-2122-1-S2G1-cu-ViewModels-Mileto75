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
            GamesGetGamesViewModel gamesGetGamesViewModel
                = new GamesGetGamesViewModel();
            //get the games from the repo
            gamesGetGamesViewModel.Titles = new List<string>();
            //get games from repo/database
            foreach (var game in _gameRepository.GetGames())
            {
                gamesGetGamesViewModel.Titles.Add(game?.Title ?? "<NoTitle>");
            }
            ViewBag.PageTitle = "Our Games";
            //send to the view
            return View(gamesGetGamesViewModel);
        }

        public IActionResult GameInfo(int id)
        {
            //declare the model
            GamesGameInfoViewModel gamesGameInfoViewModel
                = new GamesGameInfoViewModel();
            //get the game by id
            var game = _gameRepository.GetGames()
                .FirstOrDefault(g => g.Id == id);
            //fill the model
            gamesGameInfoViewModel.Id = game?.Id ?? 0;
            gamesGameInfoViewModel.Title = game?.Title ?? "<NoName>";
            gamesGameInfoViewModel.ImageName = game?.ImageName ?? "<NoName>";
            gamesGameInfoViewModel.Rating = game?.Rating ?? 0;
            gamesGameInfoViewModel.Developer = game?.Developer?.Name ?? "<NoDeveloper>";
            //pass to view 
            return View(gamesGameInfoViewModel);
        }
    }
}
