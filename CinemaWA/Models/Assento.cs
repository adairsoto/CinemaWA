using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Assento
    {
        public int AssentoId { get; set; }
        [Display(Name = "Número do Assento")]
        public int NumeroAssento { get; set; }
        [Display(Name = "Informações")]
        public string AssentoInfo { get; set; }
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }
}
