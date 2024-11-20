using System.ComponentModel.DataAnnotations.Schema;

namespace aula1911.Models
{
    [Table("servidor")]
    public class Servidor
    {
        [Column("id_ser")]
        public int Id { get; set; }
        [Column("nome_ser")]
        public string? Nome { get; set; }
        [Column("cpf_ser")]
        public string? CPF { get; set; }
        [Column("siape_ser")]
        public int SIAPE { get; set; }
    }
}
