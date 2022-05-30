using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Display(Name = "Cliente")]
        public string ClienteNome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
