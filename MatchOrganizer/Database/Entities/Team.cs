using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string LogoRelativePath { get; set; }
        public bool NotActive { get; set; }
        public int NoWins { get; set; }
        public int NoLosses { get; set; }
        public int NoDraws { get; set; }

        #region NavigationProperties
        public ICollection<Player> Players { get; set; }
        public ICollection<Match> HostMatches { get; set; }
        public ICollection<Match> GuestMatches { get; set; }
        public ICollection<MatchTeamPlayer> MatchTeamPlayers { get; set; }
        #endregion

    }
}
