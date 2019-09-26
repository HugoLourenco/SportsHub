using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class UserRoles
    {
        public int Id { get; set; }
        public int RolesId { get; set; }
        public int PersonId { get; set; }
    }
}