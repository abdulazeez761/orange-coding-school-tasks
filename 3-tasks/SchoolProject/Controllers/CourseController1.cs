using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAppMvcsCore.Models;
using SchoolAppMvcsCore.Repos;

namespace SchoolAppMvcsCore.Controllers
{
    public class CourseController1 : Controller
    {
        private readonly ICourseRepo _courseRepo;
        private readonly ITeacherRepo _teacherRepo;
        public CourseController1(ICourseRepo courseRepo, ITeacherRepo teacherRepo)
        {
            _courseRepo = courseRepo;
            _teacherRepo = teacherRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Course> course = _courseRepo.GetCourses();
            return View(course);
        }
        [Authorize(Roles = "Teacher")]
        [HttpGet]
        public ViewResult Create()
        {

            List<Teacher> teachers = _teacherRepo.GetTeachers();
            return View(teachers);
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {

            _courseRepo.CeateCourse(course);
            List<Course> courses = _courseRepo.GetCourses();
            return View("Index", courses);

        }
        public ViewResult Delete(int id)
        {
            _courseRepo.DeleteCourse(id);
            List<Course> courses = _courseRepo.GetCourses();
            return View("Index", courses);
        }


    }
}
