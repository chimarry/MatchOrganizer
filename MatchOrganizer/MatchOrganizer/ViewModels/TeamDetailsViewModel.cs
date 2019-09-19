using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels
{
    public class TeamDetailsViewModel
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string LogoRelativePath { get; set; }
        public bool NotActive { get; set; }
        public List<PlayerViewModel> Players { get; set; }

    }
}
