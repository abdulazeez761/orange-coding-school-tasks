using SchoolAppMvcsCore.Context;
using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly SchoolContext _dbConnection;
        public TeacherRepo(SchoolContext schoolContext)
        {
            _dbConnection = schoolContext;
        }
        public void CeateTeacher(Teacher teacher)
        {
            teacher.Role = teacher.Role ?? "Teacher";
            _dbConnection.Add(teacher);
            _dbConnection.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {

            Teacher teacher = _dbConnection.Teachers.Find(id);
            try
            {
                _dbConnection.Teachers.Remove(teacher);
                _dbConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public List<Teacher> GetTeachers()
        {
            try
            {
                List<Teacher> teachers = (from teachersObject in _dbConnection.Teachers select teachersObject).ToList();
                return teachers;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new List<Teacher>();
            }
        }

        public void Register(int teacherID, int courseID)
        {

        }

        public void UpdateTeacher()
        {

        }
    }
}
