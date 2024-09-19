using SalarioCalc.Models;

namespace FuncSala
{
    public class Calculadora
    {
        [Fact]
        public void TestarCalculo()
        {
            var f = new Funcionario()
            {
                SalarioClt = 1000,
                Desconto = 150,
                Beneficio = 10
            };

            Assert.Equal(860, SalarioCalc.Controllers.FuncionarioController.CalcularCustoFuncionario(f));
        }
    }
}