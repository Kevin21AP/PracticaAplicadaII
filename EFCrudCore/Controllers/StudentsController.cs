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

        public IActionResult actu(Estudiantes es)
        {

            Student.UpdateStudents(es);
            return RedirectToAction("Index");

        }
        public IActionResult Guardar()
        {

            return View();
        }

        public IActionResult Save(Estudiantes es)
        {
            Student.AddStudents(es);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Estudiantes es = new Estudiantes();
            es.Id = id;
            Student.DeleteStudents(es);
            return RedirectToAction("Index");
        }

        public IActionResult Load(int id)
        {
            Estudiantes es = new Estudiantes();
            es.Id=id;
            var listarEstudiante=Student.LoadInformation(es);
            return View(listarEstudiante);
        }
        [HttpPost]
        public IActionResult Insertardata(Estudiantes es)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }

    }
}
