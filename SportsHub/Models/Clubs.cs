﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class Clubs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte CompanyCode { get; set; }
        public int MyProperty { get; set; }
        public bool Active { get; set; }
    }
}