using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.ViewModels.Matches
{
    public class TeamListItemViewModel
    {
        public int TeamId { get; set; }
        public string Name { get; set; }

    }
}
