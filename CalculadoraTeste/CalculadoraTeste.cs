using Calculadora.App;

namespace CalculadoraTeste;




public class CalculadoraTestes
{
    public CalculadoraImp calc;
    public CalculadoraTestes()
    {
        calc = new CalculadoraImp();
    }

    [Fact]
    public void TesteSomar()
    {
        //Arrange
        int num1 = 5;
        int num2 = 5;
        
        //Act
        int resultado = calc.Somar(num1, num2);

        //Assert
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void TesteSbtrair()
    {
        //Arrange
        int num1 = 25;
        int num2 = 5;
        
        //Act
        int resultado = calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void TesteMultiplicar()
    {
        //Arrange
        int num1 = 5;
        int num2 = 5;
        
        //Act
        int resultado = calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(25, resultado);
    }

    [Fact]
    public void TesteDividir()
    {
        //Arrange
        int num1 = 30;
        int num2 = 5;
        
        //Act
        int resultado = calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
        int num1 = 3;
        int num2 = 0;

        int resultado = calc.Dividir(num1, num2);

        Assert.Throws<DivideByZeroException>(()=> calc.Dividir(num1, num2));
    }
    

}