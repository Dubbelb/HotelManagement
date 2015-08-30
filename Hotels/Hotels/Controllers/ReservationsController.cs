using Hotels.Models;
using Hotels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class ReservationsController : Controller
    {
        SampleDataRepository sampleDataRepository = new SampleDataRepository();
        //
        // GET: /Reservations/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Reservations()
        {
            var Model = new List<Reservation>();
            Model.Add(sampleDataRepository.samplebooking());
            Model.Add(sampleDataRepository.samplebooking2());


            return View(Model);
        }

        public ActionResult Reservation(int Id)
        {
            var Model = new Reservation();
            Model = sampleDataRepository.samplebooking();
            return View(Model);
        }

        public ActionResult VacantRooms()
        {
            var Model = new List<Room>();
            Model.Add(new Room
            {
                Id = 1,
                RoomType = 2
            });

            return View(Model);
        }

        
    }
}
