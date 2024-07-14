using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public interface ITeacherRepo
    {
        public List<Teacher> GetTeachers();
        public void UpdateTeacher();
        public void DeleteTeacher(int id);
        public void CeateTeacher(Teacher teacher);
        public void Register(int teacherID, int courseID);
    }
}
