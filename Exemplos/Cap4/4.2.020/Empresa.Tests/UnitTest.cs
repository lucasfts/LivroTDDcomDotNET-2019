using Empresa;
using NUnit.Framework;

namespace Tests
{

    public class CalculadoraDeSalarioTest
    {

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();

            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }
    }
}