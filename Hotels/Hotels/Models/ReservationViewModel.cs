using Hotels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotels.Models
{
    public class ReservationViewModel
    {
        public Reservation Reservation { get; private set; }

        public ReservationViewModel()
        {
        
        }
    }
}