using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsHub.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string NIF { get; set; }
        public string Email { get; set; }
        public string InsuranceNr { get; set; }
        public byte UserId { get; set; }
        public byte ClubId { get; set; }
        public bool Active { get; set; }

    }
}