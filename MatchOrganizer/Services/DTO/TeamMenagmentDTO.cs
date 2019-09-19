using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class TeamMenagmentDTO
    {
        public List<PlayerDTO> PlayersInTeam { get; set; }
        public TeamDTO Team { get; set; }
    }
}
