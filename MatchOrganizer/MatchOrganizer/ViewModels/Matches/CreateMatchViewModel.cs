using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels.Matches
{
    public class CreateMatchViewModel
    {
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public int HostScore { get; set; }
        public int GuestScore { get; set; }


        public int HostTeamId { get; set; }
        public int GuestTeamId { get; set; }

        public List<int> HostPlayerList { get; set; }
        public List<int> GuestPlayerList { get; set; }
        public List<PlayerViewModel> PlayersInMatch { get; set; }


    }
    public class CreateMatchValidator : AbstractValidator<CreateMatchViewModel>
    {
        public CreateMatchValidator()
        {
            RuleFor(x => x.HostTeamId).NotNull().NotEqual(x => x.GuestTeamId).WithMessage("Host team cannot be the same as guest team");
            RuleFor(x => x.GuestTeamId).NotNull().NotEqual(x => x.HostTeamId).WithMessage("Guest team cannot be the same as host team.");
            RuleFor(x => x.StartTime).GreaterThanOrEqualTo(DateTime.Today).WithMessage("You must not select date in past.");
            RuleFor(x => x.HostPlayerList).NotNull();
            RuleFor(x => x.GuestPlayerList).NotNull();

        }
    }
}
