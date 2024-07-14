using Microsoft.AspNetCore.Mvc;
using SchoolAppMvcsCore.Models;
using SchoolAppMvcsCore.Repos;

namespace SchoolAppMvcsCore.Controllers
{
    public class TeacherController1 : Controller
    {
        private readonly ITeacherRepo _teacherRepo;
        public TeacherController1(ITeacherRepo teahcerRepo)
        {
            _teacherRepo = teahcerRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Teacher> teachers = _teacherRepo.GetTeachers();
            return View(teachers);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            _teacherRepo.CeateTeacher(teacher);
            List<Teacher> teachers = _teacherRepo.GetTeachers();
            return View("Index", teachers);
        }
        public ViewResult Delete(int id)
        {
            _teacherRepo.DeleteTeacher(id);
            List<Teacher> teachers = _teacherRepo.GetTeachers();
            return View("Index", teachers); ;
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(int TeacherID, int courseID)
        {
            return View();
        }
    }
}
