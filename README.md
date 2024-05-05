<h1>Sistema Coleção de Jogos em C#</h1>

<p align="justify">Este projeto tem como objetivo fornecer uma aplicação simples em C# para gerenciamento de uma coleção de jogos, desenvolvida como parte do curso "Criando seu Primeiro Programa" da Alura. Ele foi concebido para auxiliar no aprendizado e prática dos conceitos fundamentais de lógica de programação, proporcionando uma experiência prática na construção de um programa funcional.</p>
<hr>

<h2>Sumário</h2>

<p>◻️ <a href="#projeto-collection-game">Projeto</a></p>

<div class="primeiro-projeto">
  <ul><a href="#CollectionGame">Collection Game</a>
    <details>
      <summary>Detalhes</summary>
      <ul>◻️ Prévia da Solução</ul>
      <ul>◻️ Principais Comandos</ul>
      <ul>◻️ Funções
      <ul>◻️ Exibir Menu</ul>
      <ul>◻️ Exibir Titulo</ul>
      <ul>◻️ Cadastrar Jogo</ul>
      <ul>◻️ Exibir Jogos</ul>
      <ul>◻️ Avaliar Jogo</ul>
      <ul>◻️ Exibir Nota Média</ul>
      </ul>
    </details>
  </ul>
</div>
<hr>

<div class="primeiro-projeto">
  <h1>Prévia da Solução</h1>
  <p align="justify">Para desenvolver o projeto, criamos um menu de opções interativo que permite ao usuário administrar sua coleção de jogos. A solução proposta inclui funcionalidades para cadastrar novos jogos adquiridos,     visualizar todos os jogos na coleção e atribuir notas aos jogos conforme os amigos vão jogando. Além disso, o usuário pode visualizar a média final das notas atribuídas a cada jogo, proporcionando uma visão abrangente da     popularidade ou qualidade dos jogos em seu grupo de jogadores.</p>

  <h2>Principais Comandos</h2>
  <ul>
    <li></l>Console.Clear(): Limpa a tela do console para uma nova exibição.</li>
    <li>Console.WriteLine(): Imprime uma mensagem ou linha de texto no console.</li>
    <li>Console.ReadLine(): Captura a entrada de texto do usuário no console.</li>
    <li>Console.ReadKey(): Aguarda até que o usuário pressione uma tecla no console.</li>
    <li>int.Parse(): Converte uma string em um número inteiro.</li>
    <li>colecaoDeJogos.Add(): Adiciona um novo jogo à coleção de jogos.</li>
    <li>colecaoDeJogos.ContainsKey(): Verifica se a coleção de jogos contém um determinado jogo.</li>
    <li>List<int>.Add(): Adiciona um elemento à lista de notas de um jogo.</li>
    <li>List<int>.Average(): Calcula a média dos valores em uma lista de inteiros.</li>
    <li>Thread.Sleep(): Pausa a execução do programa por um determinado período de tempo, em milissegundos.</li>
  </ul>
  <hr>
  <details>
    <summary><b>Exibir Menu</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Esta função apresenta um menu interativo ao usuário, permitindo que ele escolha entre diferentes opções de interação com o sistema. Ela direciona o fluxo de execução para outras funções com base na escolha do usuário.</p>

  <details>
    <summary><b>Exibir Titulo</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">A função "ExibirTitulo" tem como objetivo apresentar um título formatado de maneira estilizada na tela. Para isso, ela utiliza a quantidade de caracteres ao validar o tamanho da string passada como parâmetro na função. O título é exibido com asteriscos acompanhando, proporcionando uma formatação visualmente atraente e destacada.</p>

  <details>
    <summary><b>Cadastrar Jogo</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Permite ao usuário cadastrar um novo jogo. Verifica se o nome do jogo não está em branco e o adiciona à coleção de jogos.</p>

  <details>
    <summary><b>Exibir Jogos</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Exibe todos os jogos cadastrados na coleção.</p>

  <details>
    <summary><b>Avaliar Jogo</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Permite ao usuário atribuir uma nota a um jogo específico. Verifica se o jogo existe na coleção e, em caso afirmativo, solicita a nota e a armazena.</p>

  <details>
    <summary><b>Exibir Nota Média</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Calcula e exibe a nota média de um jogo específico. Verifica se o jogo existe na coleção e, em caso afirmativo, calcula a média das notas atribuídas a ele.</p>

</div>

<br>
<p><a href="#sumário">Voltar para o início</a></p>
<hr>
