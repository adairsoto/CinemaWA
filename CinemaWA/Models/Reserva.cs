using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int SessaoId { get; set; }
        [Display(Name = "Sessão")]
        public Sessao? Sessao { get; set; }
        public int AssentoId { get; set; }
        public Assento? Assento { get; set; }
    }
}
