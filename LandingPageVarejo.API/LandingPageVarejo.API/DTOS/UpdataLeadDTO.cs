using System.ComponentModel.DataAnnotations;

namespace LandingPageVarejo.API.DTOS
{
    public class UpdataLeadDTO
    {
        [Required(ErrorMessage = "campo nome é obrigatório")]
        public string Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
    }
}
