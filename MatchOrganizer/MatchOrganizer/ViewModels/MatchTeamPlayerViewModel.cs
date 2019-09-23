using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels
{
    public class MatchTeamPlayerViewModel
    {
        public int MatchId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public int Score { get; set; }

    }
}
