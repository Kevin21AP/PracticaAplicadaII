using EFCrudCore.Models;

namespace EFCrudCore.Services
{
    public interface IEstudiantes
    {
        public void AddStudents(Estudiantes es);
        public void UpdateStudents(Estudiantes es);
        
        public void DeleteStudents(Estudiantes es);

        public List<Estudiantes> GetStudents();

    }
}
