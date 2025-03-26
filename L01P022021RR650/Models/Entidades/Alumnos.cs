using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Alumnos
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El campo Codigo es obligatorio.")]
        [DisplayName("Codigo")]
        public string codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        [DisplayName("Nombres")]
        public string nombres { get; set; }
        [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
        [DisplayName("Apellidos")]
        public string apellidos { get; set; }
        [Required(ErrorMessage = "El campo Dui es obligatorio.")]
        [DisplayName("Dui")]
        public int dui { get; set; }
        [Required(ErrorMessage = "El campo Estado es obligatorio.")]
        [DisplayName("Estado")]
        public int estado { get; set; }
    }
}
