using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class TeamDetailsDTO
    {
        public TeamDTO TeamDTO { get; set; }
        public List<PlayerDTO> Players { get; set; }
    }
}
