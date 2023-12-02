using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes;

public class PatioTeste
{
    [Fact]
    public void ValidaFaturamento()
    {
        // Arrange
        var estacionamento = new Patio();
        var veiculo = new Veiculo();
        veiculo.Proprietario = "Andre Silva";
        veiculo.Cor = "Verde";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Modelo = "Fusca";
        veiculo.Placa = "asd-9999";
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        
        //Act 
        double faturamento = estacionamento.TotalFaturado();
        
        Assert.Equal(2,faturamento);
        
    }

    [Theory]
    [InlineData("Andre Silva", "asd-9899", "verde","Gol")]
    [InlineData("Andrei Silva", "asd-9999", "verde claro","Gol")]
    [InlineData("Luiza Silva", "asd-9499", "vermelho","Gol")]
    public void ValidaFaturamentoComVariosVeiculos(string propietario,
        string placa,
        string cor,
        string modelo)
    {
        var estacionamento = new Patio();
        var veiculo = new Veiculo();
        veiculo.Proprietario = propietario;
        veiculo.Cor = cor;
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        
        double faturamento = estacionamento.TotalFaturado();
        
        Assert.Equal(2,faturamento);
    }
    [Theory]
    [InlineData("Luiza Silva", "asd-9499", "vermelho","Gol")]
    public void LocalizaVeiculoPatio(string propietario,
        string placa,
        string cor,
        string modelo)
    {
        var estacionamento = new Patio();
        var veiculo = new Veiculo();
        veiculo.Proprietario = propietario;
        veiculo.Cor = cor;
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        Veiculo consultado = estacionamento.PesquisaVeiculo(placa);
        
        Assert.Equal(placa, consultado.Placa);
    }
    
    [Fact]
    public void DadosAutomovel()
    {
        //Arrange
        var carro = new Veiculo();
        carro.Proprietario = "Carlos Silva";
        carro.Placa = "ZAP-7419";
        carro.Cor = "Verde";
        carro.Modelo = "Variante";

        //Act
        string dados = carro.ToString();

        //Assert
        Assert.Contains("Ficha do veículo:", dados);
    }
}