using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizerAPI.Model
{
    public class MatchModel
    {
        public int MatchId { get; set; }
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public int HostScore { get; set; }
        public int GuestScore { get; set; }
        public bool NotActive { get; set; }

        public int Status { get; set; }
        public TeamModel HostTeam { get; set; }
        public TeamModel GuestTeam { get; set; }
        public List<PlayerModel> HostTeamPlayers { get; set; }
        public List<PlayerModel> GuestTeamPlayers { get; set; }

    }
}
