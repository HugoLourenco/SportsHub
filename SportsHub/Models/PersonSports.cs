﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class PersonSports
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SportId { get; set; }
        public int ClassesId { get; set; }
    }
}