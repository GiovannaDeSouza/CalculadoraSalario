using System.ComponentModel.DataAnnotations;

namespace SalarioCalc.Models
{
    public class Funcionario
    {
        [StringLength(30, ErrorMessage = "O nome pode ter no máximo 30 caracteres.")]
        public string Nome { get; set; }
        public decimal SalarioClt { get; set; }
        public decimal Desconto { get; set; }
        public decimal Beneficio { get; set; }
    }
}
