using SchoolAppMvcsCore.Context;
using SchoolAppMvcsCore.Models;

namespace SchoolAppMvcsCore.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SchoolContext _dbConnection;

        public StudentRepo(SchoolContext dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<Student> GetStudents()
        {
            try
            {
                List<Student> students = (from stdsObj in _dbConnection.Students select stdsObj).ToList();
                return students;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new List<Student>();

            }



        }
        public void CeateStudent(Student student)
        {
            student.Role = student.Role ?? "Student";
            _dbConnection.Students.Add(student);
            _dbConnection.SaveChanges();

        }

        public void DeleteStudents(int id)
        {
            try
            {
                Student student = _dbConnection.Students.Find(id);
                if (student != null)
                {
                    _dbConnection.Students.Remove(student);
                    _dbConnection.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"Error removing student: {ex.Message}");
            }
        }



        public void Register(int studentID, int courseID)
        {
            Student student = (from studentObject in _dbConnection.Students where studentObject.StudentId == studentID select studentObject).FirstOrDefault();
            StudentCourse studentCourse = new StudentCourse();
            studentCourse.StudentId = studentID;
            studentCourse.CourseId = courseID;
            _dbConnection.Add(studentCourse);
            _dbConnection.SaveChanges();
        }

        public void UpdateStudents()
        {

        }
    }
}
