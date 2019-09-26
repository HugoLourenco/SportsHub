using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class TrackingDates
    {
        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime ModifiedBy { get; set; }
    }
}