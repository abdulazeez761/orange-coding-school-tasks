using SchoolAppMvcsCore.Models;
namespace SchoolAppMvcsCore.Repos
{
    public interface IStudentRepo
    {
        public List<Student> GetStudents();
        public void UpdateStudents();
        public void DeleteStudents(int id);
        public void CeateStudent(Student student);
        public void Register(int studentID, int courseID);

    }
}
