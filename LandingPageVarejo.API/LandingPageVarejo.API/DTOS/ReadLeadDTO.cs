using System;
using System.ComponentModel.DataAnnotations;

namespace LandingPageVarejo.API.DTOS
{
    public class ReadLeadDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "campo nome é obrigatório")]
        public string Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
