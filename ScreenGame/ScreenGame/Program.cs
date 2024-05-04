Dictionary<string, List<int>> colecaoDeJogos = new Dictionary<string, List<int>>();

void ExibirOpções() 
{ 
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

    Console.Write("Digte uma opção: ");
    int opcaoDigitada = int.Parse(Console.ReadLine());

    switch (opcaoDigitada)
    {
        case 1:
            Console.WriteLine("1");
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
}

void cadastrarJogo() 
{

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