# Lista de Exercicios C#
Coleção orientada ao aprendizado de lógica e estruturas básicas em C# usando aplicações console individuais.

## Propósito
Este repositório organiza dez exercícios sequenciais (volume, consumo, conversões, decisões e loops) para fixar leitura de entrada, cálculos e mensagens formatadas. Cada pasta contém uma aplicação independente que pode ser aberta pelo `ListaExercicios.sln`, tornando-o ideal como um projeto de estudos dirigido.

## Estrutura
- `Ex01_VolumeCaixa` Calcula o volume de uma caixa retangular conforme.
- `Ex02_ConsumoCombustivel` – pergunta quilômetros inicial/final e litros utilizados para devolver o consumo médio (Km/L).
- `Ex03_CelsiusFahrenheit` – conversão entre escalas de temperatura básica.
- `Ex04_SalarioVendedor` – determina salário total do vendedor com comissão.
- `Ex05_MediaPonderada` – calcula média ponderada de três valores com pesos definidos.
- `Ex06_SomaMenorQue` – soma números enquanto cada entrada for menor que um limite.
- `Ex07_IMC` – lê peso e altura para retornar classificação do IMC.
- `Ex08_ParOuImpar` – classifica um número como par ou ímpar.
- `Ex09_Fatorial` – calcula o fatorial de um número inteiro positivo.
- `Ex10_FizzBuzz` – implementa o clássico FizzBuzz com tratamento para múltiplos de 3 e 5.

Cada exercício compartilha a mesma estrutura mínima (um `Program.cs` com uma sequência de `Console.WriteLine`/`ReadLine`) e pode ser expandido com validações, testes e comentários pedagógicos.

## Tecnologias
- [.NET 9 SDK](https://dotnet.microsoft.com) (versão usada para criar a solution)
- C# 12 (console apps simples)

## Como executar
1. Clone o repositório e abra a solução no Visual Studio ou com `dotnet`:  
   ```
   dotnet restore ListaExercicios.sln
   ```
2. Execute o projeto desejado, por exemplo:
   ```
   dotnet run --project Ex02_ConsumoCombustivel
   ```
3. Repita para cada pasta conforme o exercício que quiser testar.

> Dica: mantenha um terminal separado para cada projeto se quiser comparar entradas e saídas simultâneas.


