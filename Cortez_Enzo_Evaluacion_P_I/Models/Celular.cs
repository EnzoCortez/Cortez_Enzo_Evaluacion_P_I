using System.ComponentModel.DataAnnotations;

namespace Cortez_Enzo_Evaluacion_P_I.Models
{
    public class Celular

    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(800)]
        public string Modelo { get; set; }
        [Range(0,5000)]
        public double Precio { get; set; }
        public DateOnly Año { get; set; }
    }
}
