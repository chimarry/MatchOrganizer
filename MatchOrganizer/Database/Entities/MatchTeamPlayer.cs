using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class MatchTeamPlayer
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public int Score { get; set; }

        #region NavigationProperties
        public Team Team { get; set; }
        public Player Player { get; set; }
        public Match Match { get; set; }
        #endregion
    }
}
