# Lista de Exercícios 1

Resolva os seguintes exercícios usando como referência o artigo [Um tour pela linguagem C#](https://docs.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/) na documentação da Microsoft.

## Antes de Começar

Instale os seguintes programas:

- [Visual Studio Code](https://code.visualstudio.com/)
- [Download .NET](https://dotnet.microsoft.com/en-us/download)
- 
Execute os seguintes comandos para criar e executar um projeto C# básico.

- Abra o Visual Studio Code
- Dentro do programa, abra a pasta onde deseja codificar os exercícios
- Crie uma pasta para o exercício do lado esquerdo da janela.
- Abra o terminal integrado pelo menu `Ver` => `Terminal`.
- Escreva o seguinte comando para criar o projeto:
```powershell
dotnet new console
```
- Uma estrutura de projeto será criada. Abra o arquivo `Program.cs` e escreva o código lá.
- Pressione F5 para rodar o projeto.

Da primera vez que fizer isso o Visual Studio Code perguntará se você deseja instalar extensões recomendadas para C#. Aceite e aguarde a instalação terminar. Reinicie o Visual Studio Code.

### Habilitando depuração no console

Para ler valores do console dentro do Visual Stdudio Code é preciso habilitar o terminal externo ou integrado. Configure isso pelo menu `Executar`=> `Abrir as Configurações` e alterando a seguinte linha:
```json
"console": "integratedTerminal",
```

## 0) .NET In-Browser Tutorial

Antes decomeçarmos, visite o site [.NET In-Browser Tutorial](https://dotnet.microsoft.com/en-us/learn/dotnet/in-browser-tutorial/1) e execute o tutorial interativo.

## 1) Maior Número

Escreva um programa que utilize a função [`Console.ReadLine()`](https://docs.microsoft.com/pt-br/dotnet/api/system.console.readline?view=net-6.0) para ler 2 valores digitados pelo usuário e a função [`int.Parse(texto)`](https://docs.microsoft.com/pt-br/dotnet/api/system.int32.parse?view=net-6.0) para extrair seu valor numérico, um por vez, e determinar qual é o maior.

## 2) Maior Número - While

Modifique o programa do exercício anterior para ler números do console indefinidamente até o usuário digitar `fim` e, a cada iteração, indicar qual foi o maior número lido até o momento.

## 3) Maior Número - TryParse

Modifique o programa anterior para usar a função [`int.TryParse()`](https://docs.microsoft.com/pt-br/dotnet/api/system.int32.tryparse?view=net-6.0) para tratar entradas inválidas. Informe o problema ao usuário caso o texto digitado não seja um número válido nem a palavra `fim`.

## 4) Maior Número: For

Modifique o programa anterior para que o usuário digite previamente quantos números serão inseridos.
- Não aceite mais a instrução `sair` e só informe o maior valor digitado no final do programa.
- Utilize a instrução `for`ao invés da instrução `while`, já que agora sabemos a quantidade de números que deve ser lida.
- Caso o usuário insira um número inválido, o programa deve continuar perguntando aquele número.

## 5) Maior Número - Cores no Console

Modifique o programa do exercício anterior para que a mensagem de erro quando o usuário digita um valor inválido seja exibida em vermelho e a mensagem com o resultado em verde. As demais mensagens devem ser exibidas na cor original do console.

## 6) Maior Número - Array

Modifique o programa do exercício anterior para que os números seja inseridos de uma única vez, separados por espaços (ex: `1 2 7 4 5`).
- Se alguma entrada não for válida, exiba um texto de erro e encerre o programa.

**DICA:** utilize o método [`StringSplit()`](https://docs.microsoft.com/pt-br/dotnet/api/system.string.split?view=net-6.0) para separar os números digitados pelo usuário. Aprenderemos mais sobre a classe `String` na próxima lista.

## 7) Maior Número - Funções

Modifique o programa anterior de forma que ele fique mais organizado. Cada função deve ter até 5 linhas.

## 8) Números Pares e Ímpares

Modifique o programa anterior de forma que ao final sejam exibidos quais são pares e quais são ímpares. O operador de módulo no C# é o `%`

## 9) Soma dos Números

Modifique o programa anterior para que seja exibido também a soma dos valores digitados.

## 10) Média

Modifique o programa anterior para que ele exiba a média dos números. Use o tipo de dado `decimal` para calcular a média.