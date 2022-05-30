using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        [Display(Name = "Sala")]
        public string SalaNome { get; set; }
    }
}
