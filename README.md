# streaming-flix-xunit

Lista de Exercícios — Garantia da Qualidade de Software (Gestão e Qualidade de Software).

**Aluno:** Patrick Oliveira Rabelo de Brito — RA 4251923386

## Visão geral da aplicação

Aplicação console .NET 10 que representa as regras de planos de um serviço de streaming. A classe `PlanoStreamingService` (em `StreamingFlix.App`) concentra as regras de negócio do "Desenvolvedor 1"; a suíte parametrizada cobre as tarefas do "Desenvolvedor 2"; e este repositório, com documentação e licença, fecha as tarefas do "Desenvolvedor 3".

1. `ObterClassificacaoPorQualidade(int telasSimultaneas)` (string) — `"BÁSICO"` para 1 tela, `"PADRÃO"` para 2 a 3 telas e `"PREMIUM"` para 4 ou mais.
2. `CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)` (int) — 10% de desconto para contratos de 6 a 11 meses e 20% para 12 meses ou mais.
3. `PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)` (bool) — `true` apenas se a idade for maior ou igual a 18 **e** o controle parental estiver desativado.

> Observação: a lista não descreve a faixa de 3 telas. Ela foi tratada como `"PADRÃO"`, por continuidade entre 2 e 4 telas.

## Requisitos técnicos

- .NET 10 (SDK 10.0 ou superior)
- xUnit 2.9.3

## Cobertura dos testes parametrizados

A suíte usa `[Theory]` com `[InlineData]`, gerando 9 casos de teste individuais:

- **Classificação de planos:** `[InlineData(1, "BÁSICO")]`, `[InlineData(2, "PADRÃO")]`, `[InlineData(4, "PREMIUM")]`.
- **Cálculo de desconto:** `[InlineData(50, 1, 50)]` (sem desconto), `[InlineData(50, 6, 45)]` (10%) e `[InlineData(50, 12, 40)]` (20%).
- **Validação de acesso:** `[InlineData(20, false, true)]`, `[InlineData(20, true, false)]` e `[InlineData(16, false, false)]`.

## Estrutura

```
StreamingFlix.slnx
StreamingFlix.App/     # Projeto console (código de produção)
StreamingFlix.Tests/   # Projeto de testes xUnit
```

## Como clonar o projeto e rodar a aplicação

```bash
git clone https://github.com/TheSirLeaf/streaming-flix-xunit.git
cd streaming-flix-xunit
dotnet run --project StreamingFlix.App
```

## Como executar os testes

```bash
dotnet test
```

## Licença

MIT — veja [LICENSE](LICENSE).
