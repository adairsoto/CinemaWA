using System;
using System.ComponentModel.DataAnnotations;

namespace CinemaWA.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        [Display(Name = "Sessão")]
        public string SessaoNome { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Início da Sessão")]
        public DateTime SessaoInicio { get; set; }
        [Display(Name = "Informações")]
        public string Sessaoinfo { get; set; }
        [Display(Name = "Filme")]
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }
        [Display(Name = "Sala")]
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }
}
