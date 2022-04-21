using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCrudCore.Models
{
    public class Estudiantes
    {
        [Key]//representa llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// para que vaya generando id autoincrement
        public int Id { get; set; }

        public string Name { get; set; } // al agregar ? estamos diciendo que acepta la db y ef valores nulos
        public string LastName { get; set; }

    }
}
