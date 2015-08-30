using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotels.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public List<Room> ReservedRooms { get; set; }
        public string Comment { get; set; }
        public bool Paid { get; set; }
    }
}