using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels.TeamMenagment

{
    public class IndexTeamViewModel
    {
        public int TeamId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field name is required.")]
        public string Name { get; set; }


        [Display(Name = "Number of players")]
        public int NoPlayers { get; set; }
    
    }
}
