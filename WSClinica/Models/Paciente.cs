using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WSClinica.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }
        public int NroHistClinica { get; set; }

        public int IdMedico { get; set; }

        [ForeignKey("IdMedico")]
        public Medico Medico { get; set; }
    }
}
