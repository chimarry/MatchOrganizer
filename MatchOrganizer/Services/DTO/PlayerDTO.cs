using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTO
{
    public class PlayerDTO
    {
        public int PlayerId { get; set; }
        public string FullName { get; set; }
        public int TeamId { get; set; }
        public bool NotActive { get; set; }
    }
}
