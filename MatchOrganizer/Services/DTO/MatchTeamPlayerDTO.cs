using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class MatchTeamPlayerDTO
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public int Score { get; set; }


    }
}
