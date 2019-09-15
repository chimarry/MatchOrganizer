using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class TeamDTO
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string LogoRelativePath { get; set; }
        public bool NotActive { get; set; }
        public int NoWins { get; set; }
        public int NoLosses { get; set; }
        public int NoDraws { get; set; }

    }
}
