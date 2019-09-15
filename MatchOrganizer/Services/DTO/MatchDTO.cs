using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class MatchDTO
    {
        public int MatchId { get; set; }
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public int HostScore { get; set; }
        public int GuestScore { get; set; }
        public bool NotActive { get; set; }
        public int HostTeamId { get; set; }
        public int GuestTeamId { get; set; }
        public int StatusId { get; set; }

    }
}
