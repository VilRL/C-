<h1>🚀Game Collection System in C#</h1>

<p align="justify">This project aims to provide a simple application in C# for managing a game collection, developed as part of the "Creating Your First Program" course at Alura. It was designed to assist in learning and practicing fundamental programming logic concepts, providing a hands-on experience in building a functional program.</p>
<hr>

<h2>🎓Summary</h2>

<p>◻️Project</p>

<div class="primeiro-projeto">
  <ul>Collection Game
    <details>
      <summary>Details</summary>
      <ul>◻️ Solution Preview</ul>
      <ul>◻️ Main Commands</ul>
      <ul>◻️ Functions
      <ul>◻️ Display Menu</ul>
      <ul>◻️ Register Game</ul>
      <ul>◻️ Display Games</ul>
      <ul>◻️ Rate Game</ul>
      <ul>◻️ Display Average Rating</ul>
      </ul>
    </details>
  </ul>
</div>
<hr>

<div class="primeiro-projeto">
  <h1>🎯Solution Preview</h1>
  <p align="justify">To develop the project, we created an interactive options menu that allows the user to manage their game collection. The proposed solution includes functionalities to register newly acquired games, view all games in the collection, and assign ratings to games as friends play them. Additionally, the user can view the final average ratings of each game, providing a comprehensive view of the popularity or quality of the games in their gaming group.</p>

  <h2>Main Commands</h2>
  <ul>
    <li></l>Console.Clear(): Clears the console screen for a new display.</li>
    <li>Console.WriteLine(): Prints a message or line of text on the console.</li>
    <li>Console.ReadLine(): Captures user text input from the console.</li>
    <li>Console.ReadKey(): Waits until the user presses a key on the console.</li>
    <li>int.Parse(): Converts a string into an integer.</li>
    <li>colecaoDeJogos.Add(): Adds a new game to the game collection.</li>
    <li>colecaoDeJogos.ContainsKey(): Checks if the game collection contains a specific game.</li>
    <li>List<int>.Add(): Adds an element to the list of a game's ratings.</li>
    <li>List<int>.Average(): Calculates the average of values in a list of integers.</li>
    <li>Thread.Sleep(): Pauses program execution for a certain period of time, in milliseconds.</li>
  </ul>
  <hr>
  <h3>Display Menu</h3>
  <img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/Menu.png" alt=""/>
  <details>
    <summary><b>🛠Code</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/ExibirOpcoes.png" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">This function presents an interactive menu to the user, allowing them to choose between different options for interacting with the system. It directs the flow of execution to other functions based on the user's choice.</p>

  <h3>Register Game</h3>
  <img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/gif/cadastrarJogo.gif" alt=""/>
  <details>
    <summary><b>🛠Code</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/CadastrarJogo.png" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Allows the user to register a new game. Checks if the game name is not blank and adds it to the game collection.</p>

  <h3>Display Games</h3>
  <img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/gif/exibirJogos.gif" alt=""/>
  <details>
    <summary><b>🛠Code</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/ExibirJogo.png" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Displays all games registered in the collection.</p>

  <h3>Rate Game</h3>
  <img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/gif/avaliarJogo.gif" alt=""/>
  <details>
    <summary><b>🛠Code</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/AvaliarJogo.png" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Allows the user to assign a rating to a specific game. Checks if the game exists in the collection and, if so, prompts for the rating and stores it.</p>

  <h3>Display Average Rating</h3>
  <img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/gif/exibirNotaMedia.gif" alt=""/>
  <details>
    <summary><b>🛠Code</b></summary>
    <br>
    <table align="center">
      <tr>
        <td alignt="center"><img src="https://github.com/VilRL/C-Sharp-Primeiro-Programa/blob/main/Img/ExibirMediaDoJogo.png" alt=""/>
        </td>     
      </tr>
    </table>
  </details>
  <p align="justify">Calculates and displays the average rating of a specific game. Checks if the game exists in the collection and, if so, calculates the average of the ratings assigned to it.</p>

</div>

<br>
<hr>
```