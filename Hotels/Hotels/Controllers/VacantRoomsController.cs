using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class VacantRoomsController : Controller
    {
        //
        // GET: /VacantRooms/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VacantRoomsDate()
        {
            return View();
        }
        public ActionResult VacantRoomsList(DateTime StartDate, DateTime EndDate)
        {
            var Model = new List<Room>();
            return View();
        }

    }
}
