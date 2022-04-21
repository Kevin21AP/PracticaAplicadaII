using EFCrudCore.Data;
using EFCrudCore.Models;
using EFCrudCore.Services;

namespace EFCrudCore.Repository
{
    //capa de repository sirve para acceder a la db
    //es una capa logica de la db
    public class StudentsRepository : IEstudiantes
    {
        //especificar la conexion a la db solo una ves
        //(ApplicationDBContext se encargara por nosotros para trabajar las entidades de la db)
        private ApplicationDBContext app;

        public StudentsRepository(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudents(Estudiantes es)
        {
            //app pertenece a ApplicationDBContext
            //en ApplicationDBContext existe un DBSet el cual se llama Estudiantes que
            //es la representacion de una tabla en la db 

            app.Estudiantes.Add(es);
            app.SaveChanges();//Guardar cambios en la db
        }

        public void DeleteStudents(Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();
            //throw new NotImplementedException();
        }


        //es un arreglo de muchas dimensiones IEnumerable  se usa en un select
        // ICollection se usa cuando se necesita usar diferentes hilos del S.O 

        public List<Estudiantes> GetStudents()
        {
            
            return app.Estudiantes.ToList();
            //throw new NotImplementedException();
        }

        public Estudiantes LoadInformation(Estudiantes es)
        {
            //crear consulta en la db mediante linq con expresion landam para extraer un solo registro
            // expresion landan toma dentro de la clase estudiante 
            var listarEstudiante = app.Estudiantes.Where(x => x.Id==es.Id).FirstOrDefault();
            return listarEstudiante;
        }

        public void UpdateStudents(Estudiantes es)
        {
           // throw new NotImplementedException();
        }


    }
}
