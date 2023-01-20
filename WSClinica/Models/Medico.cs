using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WSClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        public int Matricula { get; set; }
        public int? FechaNacimiento  { get; set; }

        public List<Paciente> Pacientes { get; set; }


        public int IdEspecialidad { get; set; }

        [ForeignKey("IdEspecialidad")]
        public Especialidad Especialidad { get; set; }
    }
}
