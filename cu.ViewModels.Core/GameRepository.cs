using System.Collections.Generic;
using System.Linq;

namespace Wba.Oefening.Games.Core
{
    public class GameRepository
    {
        public IEnumerable<Game> GetGames()
        {
            DeveloperRepository developerRepository = new DeveloperRepository();
            return new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "Wolfenstein Colossus",
                    Rating = 1,
                    ImageName = "wolfenstein.jpg",
                    Developer = 
                        developerRepository.GetDevelopers().
                            First(d => d.Id == 1)
                },
                new Game
                {
                    Id = 2,
                    Title ="FIFA 2020",
                    ImageName = "fifa20.jpg",
                    Rating = 2,
                    Developer =
                        developerRepository.GetDevelopers().
                            First(d => d.Id == 2)
                },
                new Game
                {
                    Id = 3,
                    Title ="Elder Scrolls V: Skyrim",
                    ImageName = "elder_skyrim.jpg",
                    Rating = 5,
                    Developer =
                        developerRepository.GetDevelopers().
                            First(d => d.Id == 3)
                },
                new Game
                {
                    Id = 4,
                    Title ="Fallout 4",
                    Rating = 3,
                    Developer =
                        developerRepository.GetDevelopers().
                            First(d => d.Id == 3)
                }
            };
        }
    }
}
