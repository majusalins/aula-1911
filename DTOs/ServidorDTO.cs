using System.ComponentModel.DataAnnotations;

namespace aula1911.DTOs
{
    public class ServidorDTO
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [Length(14, 14, ErrorMessage = "O CPF deve ter 14 caracteres.")]
        public string CPF { get; set; }
        [Required]
        public int SIAPE { get; set; }
    }
}
