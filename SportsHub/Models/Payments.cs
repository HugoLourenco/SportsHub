using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
    }
}