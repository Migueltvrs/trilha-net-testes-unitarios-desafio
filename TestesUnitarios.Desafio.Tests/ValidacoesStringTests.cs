using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange
        // Ok
        // Arrange
        var texto = "Matrix"; //
        var resultadoEsperado = 6; //

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Ok
        // Act
         var procurandoAPalavraQualquer = _validacoes.ContemCaractere(texto, textoProcurado); //

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        // Ok
        Assert.True(procurandoAPalavraQualquer); //
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        // Ok
        Assert.False(resultado); // não vai achar a palavra "teste"(var resultado = false), 
                                 // logo, a var resultado vai satistazer a condição do Assert.Faslse()
    }

    //TODO: Corrigir a anotação [Fact]
    // Ok
    [Fact] //
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange
        // Ok

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado"; // 

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
