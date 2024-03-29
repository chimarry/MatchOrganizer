﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public int TeamId { get; set; }
        public bool NotActive { get; set; }
        public Team CurrentTeam { get; set; }

        #region NavigationProperties
        public ICollection<MatchTeamPlayer> MatchTeamPlayers { get; set; }
        #endregion
    }
}
