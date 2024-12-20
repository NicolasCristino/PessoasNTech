using System.ComponentModel.DataAnnotations;

namespace ListarPessoaApp.Models
{
    public class Pessoa
    {
        [Key]
        public int PESSOA_ID { get; set; }
        public string NOME_FANTASIA { get; set; }
        public string CNPJ_CPF { get; set; }
    }
}
