using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotels.Repositories
{
    public class SampleDataRepository
    {
        public Reservation samplebooking()
        {
            var booking = new Reservation();
            booking.Id = 1;
            booking.Start = new DateTime(2015, 08, 27);
            booking.Stop = new DateTime(2015, 08, 30);
            booking.Customer = GetSampleCustomer(1);
            booking.ReservedRooms = GetSampleListOfRooms();
            return booking;
        }
        public Reservation samplebooking2()
        {
            var booking = new Reservation();
            booking.Id = 2;
            booking.Start = new DateTime(2015, 08, 31);
            booking.Stop = new DateTime(2015, 09, 03);
            booking.Customer = GetSampleCustomer(2);
            booking.ReservedRooms = new List<Room>();
            booking.ReservedRooms.Add(GetSampleRoom(2));

            return booking;
        }

        public List<Room> GetSampleListOfRooms()
        {
            var RoomList = new List<Room>();

            RoomList.Add(GetSampleRoom(1));
            RoomList.Add(GetSampleRoom(2));

            return RoomList;
        }

        public Customer GetSampleCustomer(int id)
        {
            if (id == 1)
            {
                return new Customer
                {
                    Id = 1,
                    FirstName = "Luke",
                    LastName = "Skywalker",
                    CellPhoneNumber = "073-1234567"
                };
            }
            else if (id == 2)
            {
                return new Customer
                {
                    Id = 1,
                    FirstName = "Darth",
                    LastName = "Vader",
                    CellPhoneNumber = "073-1234567"
                };
            }
            return null;
        }



        public Room GetSampleRoom(int id)
        {
            if (id == 1)
            {
                return new Room
                {
                    Id = 1,
                    RoomType = 1
                };
            }
            else if (id == 2)
            {
                return new Room
                {
                    Id = 2,
                    RoomType = 1
                };
            }
            return null;
        }
    }
}