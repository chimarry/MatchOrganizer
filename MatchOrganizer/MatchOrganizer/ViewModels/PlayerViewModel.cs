using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels
{
    public class PlayerViewModel
    {
        public int PlayerId { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Field full name is required.")]
        public int FullName { get; set; }
        public int TeamId { get; set; }
        public bool NotActive { get; set; }
    }
}
