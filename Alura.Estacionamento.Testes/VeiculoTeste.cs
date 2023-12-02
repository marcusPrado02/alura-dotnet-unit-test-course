using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes;

public class VeiculoTeste : IDisposable
{
    private Veiculo veiculo;
    public ITestOutputHelper SaidaConsoleTeste;
    public VeiculoTeste(ITestOutputHelper _saidaConsoleTeste)
    {
        SaidaConsoleTeste = _saidaConsoleTeste;
        SaidaConsoleTeste.WriteLine("Constructor Invocado");
        veiculo = new Veiculo();
    }

    [Fact(DisplayName= "Teste número 1")]
    [Trait("Funcionalidade","Frear")]
    public void TestaVeiculoAcelerarComParametro10()
    {
        var veiculo = new Veiculo();
        veiculo.Acelerar(10);
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestarVeiculoFrearComParametro10()
    {
        var veiculo = new Veiculo();
        veiculo.Frear(10);
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact(Skip= "Teste ainda não implementado")]
    public void validaNomeProprietario()
    {
        
    }
    public void Dispose()
    {
        SaidaConsoleTeste.WriteLine("Constructor Invocado");
    }
}