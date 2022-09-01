using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required]
        public int ID {get; set;}
        [Required (ErrorMessage ="O campo titulo é obrigatório!")]
        public string Titulo {get; set;}
        public string Diretor {get; set;}
        [Required (ErrorMessage ="O campo genero é obrigatório!")]
        public string Genero {get; set;}
        [Range(0,600,ErrorMessage = "O filme pode ter de 0 a 600 minutos!")]
        public int Duracao {get; set;}

    }
}