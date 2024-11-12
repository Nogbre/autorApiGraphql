using System.ComponentModel.DataAnnotations;

namespace AutoresAPI.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Nombre { get; set; }

        [Required]
        [MinLength(2)]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string Nacionalidad { get; set; }

        public string Biografia { get; set; }
    }
}
