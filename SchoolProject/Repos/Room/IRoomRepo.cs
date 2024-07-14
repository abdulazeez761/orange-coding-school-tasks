using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public interface IRoomRepo
    {
        public List<Room> GetRooms();
        public void Create(Room room);
        public void Delete(int roomID);


    }
}
