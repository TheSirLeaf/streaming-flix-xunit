namespace StreamingFlix.App;

public class PlanoStreamingService
{
    // Classificacao do plano conforme a quantidade de telas simultaneas.
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas <= 1)
        {
            return "BÁSICO";
        }

        if (telasSimultaneas < 4)
        {
            return "PADRÃO";
        }

        return "PREMIUM";
    }

    // Mensalidade com desconto: 10% de 6 a 11 meses e 20% a partir de 12 meses.
    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        if (mesesContratados >= 12)
        {
            return valorBase - valorBase * 20 / 100;
        }

        if (mesesContratados >= 6)
        {
            return valorBase - valorBase * 10 / 100;
        }

        return valorBase;
    }

    // Conteudo adulto apenas para maior de idade e sem controle parental ativo.
    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}
