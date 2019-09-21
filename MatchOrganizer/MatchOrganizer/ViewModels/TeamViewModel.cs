
using System.ComponentModel.DataAnnotations;

namespace MatchOrganizer.ViewModels
{
    public class TeamViewModel
    {

        public int TeamId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field name is required.")]
        public string Name { get; set; }


        [Display(Name = "Number of players")]
        public int NoPlayers { get; set; }


        public bool NotActive { get; set; }
    }
}
