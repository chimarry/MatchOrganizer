using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class MatchDetailsDTO
    {
        public MatchDTO Match { get; set; }
        public string HostTeamName { get; set; }
        public string GuestTeamName { get; set; }
        public string Score { get; set; }
    }
}
