namespace calculadora.teste
{
    public class calculadorateste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, calculadoraEX.calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(2, calculadoraEX.calculadora.Subtrair(4, 2));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(5, calculadoraEX.calculadora.Dividir(10, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(10, calculadoraEX.calculadora.Multiplicar(2, 5));
        }
    }
}