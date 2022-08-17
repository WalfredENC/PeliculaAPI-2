using System.ComponentModel.DataAnnotations;

namespace PeliculaAPI.Models.Dtos
{
    public class CinemaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}