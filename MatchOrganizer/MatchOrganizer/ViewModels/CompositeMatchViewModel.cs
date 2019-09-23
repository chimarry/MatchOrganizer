using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels
{
    public class CompositeMatchViewModel
    {
        public MatchViewModel MatchViewModel { get; set; }
        public List<MatchTeamPlayerViewModel> HostPlayersInMatch { get; set; }
        public List<MatchTeamPlayerViewModel> GuestPlayerInMatch { get; set; }
    }
}
