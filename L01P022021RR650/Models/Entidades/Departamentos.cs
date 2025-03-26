using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Departamentos
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "El campo Nombre del Depatamento es obligatorio.")]
        [DisplayName("Nombre del Depatamento")]
        public string departamento { get; set; }
    }
}
