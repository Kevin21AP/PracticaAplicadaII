using EFCrudCore.Models;
using EFCrudCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCrudCore.Controllers
{
    public class StudentsController : Controller
    {
        private IEstudiantes Student;

        //agrgamos el constructor para la interfaz
        public StudentsController(IEstudiantes estudiantes)
        {
            Student = estudiantes;
        }

        public IActionResult Index()
        {
            ViewBag.Student = Student.GetStudents();
            return View();
        }

        public IActionResult AddStudents(Estudiantes estudiante )
        {
            Student.AddStudents(estudiante);
            ViewBag.Student = Student.GetStudents();
            return View("Index");
        }

       
    }
}
