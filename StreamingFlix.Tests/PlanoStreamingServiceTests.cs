using StreamingFlix.App;

namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ObterClassificacaoPorQualidade_DeveRetornarClassificacaoPorTelas(int telasSimultaneas, string classificacaoEsperada)
    {
        var service = new PlanoStreamingService();

        var resultado = service.ObterClassificacaoPorQualidade(telasSimultaneas);

        Assert.Equal(classificacaoEsperada, resultado);
    }

    [Theory]
    [InlineData(50, 1, 50)]
    [InlineData(50, 6, 45)]
    [InlineData(50, 12, 40)]
    public void CalcularMensalidadeComDesconto_DeveAplicarDescontoPorTempoDeContrato(int valorBase, int mesesContratados, int valorEsperado)
    {
        var service = new PlanoStreamingService();

        var resultado = service.CalcularMensalidadeComDesconto(valorBase, mesesContratados);

        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(20, true, false)]
    [InlineData(16, false, false)]
    public void PodeAcessarConteudoAdulto_DeveValidarIdadeEControleParental(int idade, bool controleParentalAtivo, bool esperado)
    {
        var service = new PlanoStreamingService();

        var resultado = service.PodeAcessarConteudoAdulto(idade, controleParentalAtivo);

        Assert.Equal(esperado, resultado);
    }
}
