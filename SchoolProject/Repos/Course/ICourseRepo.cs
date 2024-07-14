using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public interface ICourseRepo
    {
        public List<Course> GetCourses();
        public void DeleteCourse(int id);
        public void CeateCourse(Course teacher);
        /* public void RegisterTeacher(int teacherID, int courseID);*/
    }
}
