
using Domain;

namespace Tests
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Retornar0QuandoReceberUmaStringVazia()
        {
            var result = StringCalculator.Add("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Retornar1QuandoReceber1EmUmaString()
        {
            var result = StringCalculator.Add("1");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Retornar2QuandoReceber2EmUmaString()
        {
            var result = StringCalculator.Add("2");

            Assert.Equal(2, result);
        }

        [Fact]
        public void Retornar3QuandoReceber3EmUmaString()
        {
            var result = StringCalculator.Add("3");

            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData("1,2",3)]
        [InlineData("3,2", 5)]
        [InlineData("3,2,5,7", 17)]
        [InlineData("1,2,3,4,5,6,7,8,9",45)]
        public void RetornarASomaQuandoReceberUmaStringComNumerosSeparadosPorVirgula(string numbers, int expected)
        {
            var result = StringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("2,1\n4",7)]
        public void RetornarASomaQuandoReceberUmaStringComNumerosSeparadosPorVirgulasEQuebraDeLinha(string numbers, int expected)
        {
            var result = StringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]

        public void RetornarASomaQuandoReceberUmaStringComNumerosSeparadosPorCatacteresPersonalizados(string numbers, int expected)
        {
            var result = StringCalculator.Add(numbers);

            Assert.Equal(expected, result);
        }

    }
}