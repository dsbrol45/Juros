using System;
using Xunit;
using Juros;

namespace TestesJuros
{
    public class TaxaJurosTeste
    {
        [Fact]
        public void VerificaValorTaxa()
        {
            //Arrange //Valores esperados de retorno
            decimal valorTaxaEsperado = 0.01M;

            //Act //A��o de chamar os m�todos
            TaxaJuros tx = new TaxaJuros();

            //Assert //Validar se o valor est� vindo o esperado
            Assert.Equal(valorTaxaEsperado, tx.Juros);
        }
    }
}
