using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels.TeamMenagment
{
    public class DetailsTeamViewModel
    {
        public int TeamId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field name is required.")]
        public string Name { get; set; }

        public string Desc { get; set; }
        public string LogoRelativePath { get; set; }
        public List<PlayerViewModel> Players { get; set; }

        public bool NotActive { get; set; }
    }
}
