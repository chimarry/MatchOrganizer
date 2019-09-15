﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Name { get; set; }

        public bool NotActive { get; set; }
        #region NavigationProperties
        public ICollection<Match> Matches { get; set; } 
        #endregion
    }
}