using System.ComponentModel.DataAnnotations;

namespace L01P022021RR650.Models.Entidades
{
    public class Facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }
    }
}
