using System.ComponentModel.DataAnnotations;

namespace LandingPageVarejo.API.Models
{
    public class Lead
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="campo nome é obrigatório")]
        public string Nome { get; set; }

        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
    }
}
