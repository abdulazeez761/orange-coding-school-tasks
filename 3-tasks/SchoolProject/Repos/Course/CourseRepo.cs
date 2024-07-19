using SchoolAppMvcsCore.Context;
using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public class CourseRepo : ICourseRepo
    {
        private readonly SchoolContext _dbConnection;
        public CourseRepo(SchoolContext schoolContext)
        {
            _dbConnection = schoolContext;
        }
        public void CeateCourse(Course course)
        {
            _dbConnection.Add(course);
            _dbConnection.SaveChanges();
        }

        public void DeleteCourse(int id)
        {

            Course course = _dbConnection.Courses.Find(id);
            try
            {
                _dbConnection.Courses.Remove(course);
                _dbConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }

        public List<Course> GetCourses()
        {
            try
            {
                List<Course> courses = (from CourseObject in _dbConnection.Courses select CourseObject).ToList();
                return courses;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new List<Course>();
            }
        }
    }
}

