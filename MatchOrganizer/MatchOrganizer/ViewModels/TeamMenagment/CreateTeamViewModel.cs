using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels.TeamMenagment
{
    public class CreateTeamViewModel
    {

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field name is required.")]
        public string Name { get; set; }

        public string LogoRelativePath { get; set; }

    }
}
