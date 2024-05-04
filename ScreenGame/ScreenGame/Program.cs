Dictionary<string, List<int>> colecaoDeJogos = new Dictionary<string, List<int>>();

void ExibirOpções() 
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░░█████╗░██╗░░░░░██╗░░░░░███████╗░█████╗░████████╗██╗░█████╗░███╗░░██╗
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔══██╗██║░░░░░██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║
██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░╚═╝██║░░██║██║░░░░░██║░░░░░█████╗░░██║░░╚═╝░░░██║░░░██║██║░░██║██╔██╗██║
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██╗██║░░██║██║░░░░░██║░░░░░██╔══╝░░██║░░██╗░░░██║░░░██║██║░░██║██║╚████║
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝╚█████╔╝███████╗███████╗███████╗╚█████╔╝░░░██║░░░██║╚█████╔╝██║░╚███║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░╚════╝░╚══════╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝");

    Console.WriteLine("\nDigite 1 Para Cadastrar Um Jogo");
    Console.WriteLine("Digite 2 Para Exibir Todos Os Jogos");
    Console.WriteLine("Digite 3 Para Avaliar Um Jogo");
    Console.WriteLine("Digite 4 Para Exibir A Nota Média De Um Jogo");
    Console.WriteLine("Digite 0 Para Sair\n");

    Console.Write("Digite uma opção: ");
    int opcaoDigitada = int.Parse(Console.ReadLine());

    if (opcaoDigitada < 4)
    {
        switch (opcaoDigitada)
        {
            case 1:
                cadastrarJogo();
                break;
            case 2:
                Console.WriteLine("2");
                break;
            case 3:
                Console.WriteLine("3");
                break;
            case 4:
                Console.WriteLine("4");
                break;
        }
    }else{
        Console.WriteLine("\nVocê digitou uma opção invalida!");
        ExibirOpções();
    }

}

void exibirTitulo(string titulo) 
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void cadastrarJogo() 
{
    exibirTitulo("CADASTRAR JOGO");
    Console.Write("Digite o nome do jogo: ");
    string jogoDigitado = Console.ReadLine();
    colecaoDeJogos.Add(jogoDigitado, new List<int>());
    Console.WriteLine($"\nO jogo {jogoDigitado} foi cadastrado com sucesso!!!");
    Thread.Sleep(3000);
    ExibirOpções();
}

void exibirJogos() 
{

}

void avaliarJogo() 
{ 

}

void exibirNotaMediaJogo()
{

}

ExibirOpções();