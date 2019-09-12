using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class PlayerStatistics
    {
        public int PlayerStatisticsId { get; set; }
        public int NoMatches { get; set; }
        public int NoGoals { get; set; }
        public bool NotActive { get; set; }

        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
