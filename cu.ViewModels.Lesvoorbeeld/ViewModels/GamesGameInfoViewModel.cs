using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Games.Core;

namespace cu.ViewModels.Lesvoorbeeld.ViewModels
{
    public class GamesGameInfoViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public int? Rating { get; set; }
        public string ImageName { get; set; }
    }
}
