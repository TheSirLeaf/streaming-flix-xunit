using StreamingFlix.App;

var service = new PlanoStreamingService();

Console.WriteLine($"Classificacao (2 telas): {service.ObterClassificacaoPorQualidade(2)}");
Console.WriteLine($"Mensalidade (50 por 12 meses): {service.CalcularMensalidadeComDesconto(50, 12)}");
Console.WriteLine($"Conteudo adulto (20 anos, sem controle parental): {service.PodeAcessarConteudoAdulto(20, false)}");
