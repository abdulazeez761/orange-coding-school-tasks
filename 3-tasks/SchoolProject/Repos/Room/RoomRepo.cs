using SchoolAppMvcsCore.Context;
using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public class RoomRepo : IRoomRepo
    {
        private readonly SchoolContext _dbConnection;
        public RoomRepo(SchoolContext schoolContext)
        {
            _dbConnection = schoolContext;
        }
        public void Create(Room room)
        {
            _dbConnection.Add(room);
            _dbConnection.SaveChanges();
        }

        public void Delete(int id)
        {

            Room room = _dbConnection.Rooms.Find(id);
            try
            {
                _dbConnection.Rooms.Remove(room);
                _dbConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> room = (from roomoObject in _dbConnection.Rooms select roomoObject).ToList();
                return room;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new List<Room>();
            }
        }




    }
}
