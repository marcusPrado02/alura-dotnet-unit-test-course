using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes;

public class UnitTest1
{
    [Fact(DisplayName= "Teste número 1")]
    [Trait("Funcionalidade","Frear")]
    public void TestaVeiculoAcelerar()
    {
        var veiculo = new Veiculo();
        veiculo.Acelerar(10);
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestarVeiculoFrear()
    {
        var veiculo = new Veiculo();
        veiculo.Frear(10);
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact(Skip= "Teste ainda não implementado")]
    public void validaNomeProprietario()
    {
        
    }
}