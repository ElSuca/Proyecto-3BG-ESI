using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiResults.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public string Status { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int IdAsoc { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}