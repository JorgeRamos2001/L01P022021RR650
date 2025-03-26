using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Alumnos
    {
        [Key]
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int dui { get; set; }
        public int estado { get; set; }
    }
}
