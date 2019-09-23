using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels
{
    public class MatchViewModel
    {
        public int MatchId { get; set; }
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public int HostScore { get; set; }
        public int GuestScore { get; set; }
        public bool NotActive { get; set; }
        public int HostTeamId { get; set; }
        public int GuestTeamId { get; set; }

        public string HostTeamName { get; set; }
        public string GuestTeamName { get; set; }
        public int Status { get; set; }
        public string Score { get => HostScore + ":" + GuestScore; private set { } }
    }
}
