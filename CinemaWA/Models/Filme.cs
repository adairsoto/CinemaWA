using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        [Display(Name = "Filme")]
        public string FilmeNome { get; set; }
        public string Elenco { get; set; }
        public string Tipo { get; set; }
    }
}
