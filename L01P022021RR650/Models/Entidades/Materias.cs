using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Materias
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El campo Nombre de la Materia es obligatorio.")]
        [DisplayName("Nombre de la Materia")]
        public string materia { get; set; }
        [Required(ErrorMessage = "El campo Unidades Valorativas es obligatorio.")]
        [DisplayName("Unidades Valorativas")]
        public int unidades_valorativas { get; set; }
        [Required(ErrorMessage = "El campo Estado es obligatorio.")]
        [DisplayName("Estado")]
        [Range(0, 2, ErrorMessage = "Los valores aceptados son de 0 a 2.")]
        public string estado { get; set; }
    }
}
