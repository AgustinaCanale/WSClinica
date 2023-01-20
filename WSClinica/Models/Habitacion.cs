using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSClinica.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
       
        [Key]
        public int IdHabitacion { get; set; }

        [Range(1, 100, ErrorMessage = "Solo se aceptan numeros entre 1 y 100")]

        public int Numero { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Estado { get; set; }

        public int ID { get; set; }

        [ForeignKey("ID")]
        public Clinica Clinica { get; set; }

    }
}
