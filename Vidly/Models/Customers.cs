using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int id { get; set; }
        public string name{ get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MemberShipType { get; set; }
        public DateTime Birthdate { get; set; }
    }
}