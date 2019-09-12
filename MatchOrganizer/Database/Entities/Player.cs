using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int FullName { get; set; }
        public int TeamId { get; set; }
        public bool NotActive { get; set; }
        public Team CurrentTeam { get; set; }
        public ICollection<PlayerStatistics> PlayerStatistics { get; set; }
    }
}
