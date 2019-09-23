using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizerAPI.Model
{
    public class PlayerModel
    {

        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public int TeamId { get; set; }
        public bool NotActive { get; set; }
    }
}
