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

        //mostrar datos en el view
        public IActionResult Index()
        {
            var list = Student.GetStudents();
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            Estudiantes es = new Estudiantes();
            es.Id = id;
            Student.DeleteStudents(es);
            return RedirectToAction("Index");
        }
        public IActionResult AddStudents(Estudiantes estudiante )
        {
            Student.AddStudents(estudiante);
            ViewBag.Student = Student.GetStudents();
            return View("Index");
        }

       
    }
}
