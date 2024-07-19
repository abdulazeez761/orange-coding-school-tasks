using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAppMvcsCore.Models;
using SchoolAppMvcsCore.Models.ViewModels;
using SchoolAppMvcsCore.Repos;

namespace SchoolAppMvcsCore.Controllers
{
    public class StudetnController : Controller
    {
        private readonly IStudentRepo _studentRepo;
        private readonly ICourseRepo _courseRepo;
        private readonly IWebHostEnvironment _hostEnvironment;

        public StudetnController(IStudentRepo studentRepo, ICourseRepo courseRepo, IWebHostEnvironment hostEnvironment)
        {

            _studentRepo = studentRepo;
            _courseRepo = courseRepo;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        [Authorize(Roles = "Teacher")]
        public ActionResult Index()
        {
            ViewBag.userName = "abdulaziz";
            ViewData["message"] = "message";
            List<Student> studentsList = _studentRepo.GetStudents();
            return View(studentsList);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, IFormFile StudentPhoto)
        {
            var webRootPath = Path.Combine(_hostEnvironment.WebRootPath, "UsersImages");

            // Ensure directory exists
            if (!Directory.Exists(webRootPath))
            {
                Directory.CreateDirectory(webRootPath);
            }

            Guid picName = Guid.NewGuid();
            string fullPath = Path.Combine(webRootPath, picName + Path.GetExtension(StudentPhoto.FileName));

            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                StudentPhoto.CopyTo(fileStream);
            }

            student.photoPath = Path.GetFileName(fullPath); // Save only the filename or relative path

            // Call the repository to create the student, which assigns the role
            _studentRepo.CeateStudent(student);

            List<Student> studentsList = _studentRepo.GetStudents();

            return View("Index", studentsList);
        }

        public ActionResult Delete(int id)
        {
            _studentRepo.DeleteStudents(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult RegisterStudetnForm()
        {
            if (TempData["sendToRegister"] != null)
            {
                int receivedData = (int)TempData["sendToRegister"];
                ViewBag.receivedData = receivedData;
            }
            StudentCourseVM studentCourseVM = new StudentCourseVM
            {
                Courses = _courseRepo.GetCourses(),
                Students = _studentRepo.GetStudents()
            };
            return View(studentCourseVM);
        }

        [HttpPost]
        public ActionResult RegisterStudentFormAction(int studentID, int courseID)
        {
            TempData["sendToRegister"] = studentID;
            _studentRepo.Register(studentID, courseID);
            return RedirectToAction("RegisterStudentForm");
        }
    }
}
