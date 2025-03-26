using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Facultades
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El campo Nombre de la Facultad es obligatorio.")]
        [DisplayName("Nombre de la Facultad")]
        public string facultad { get; set; }
    }
}
