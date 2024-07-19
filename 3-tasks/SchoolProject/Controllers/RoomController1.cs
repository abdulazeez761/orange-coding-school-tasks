using Microsoft.AspNetCore.Mvc;
using SchoolAppMvcsCore.Models;
using SchoolAppMvcsCore.Repos;

namespace SchoolAppMvcsCore.Controllers
{
    public class RoomController1 : Controller
    {
        private readonly IRoomRepo _roomTable;
        public RoomController1(IRoomRepo rooms)
        {
            _roomTable = rooms;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Room> rooms = _roomTable.GetRooms();
            return View(rooms);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            _roomTable.Create(room);
            List<Room> rooms = _roomTable.GetRooms();
            return View("Index", rooms);
        }
        public ViewResult Delete(int id)
        {
            _roomTable.Delete(id);
            List<Room> rooms = _roomTable.GetRooms();
            return View("Index", rooms);
        }



    }
}
