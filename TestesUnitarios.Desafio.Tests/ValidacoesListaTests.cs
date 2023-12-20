using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste
        // Ok
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar); //

        // Assert
        Assert.False(resultado); // obs: não vai achar o número 10, logo, retornará verdadeiro.
    }

    //TODO: Corrigir a anotação [Fact]
    // Ok
    [Fact] //
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste
        // Ok
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var listaMultiplicadaPor2 = _validacoes.MultiplicarNumerosLista(lista, 2); //

        // Assert
        Assert.Equal(resultadoEsperado, listaMultiplicadaPor2); //
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste
        // Ok
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = 9; //

        // Act
        var listaEsperadoRetornar9 = _validacoes.RetornarMaiorNumeroLista(lista); //

        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        // Ok
        // Assert
        Assert.Equal(resultadoEsperado, listaEsperadoRetornar9); //
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = -8; //
        
        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);
        
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
