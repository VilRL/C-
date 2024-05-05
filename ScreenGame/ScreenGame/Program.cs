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
    int opcaoDigitada = int.Parse(Console.ReadLine()!);

    if (opcaoDigitada < 5)
    {
        switch (opcaoDigitada)
        {
            case 1:
                CadastrarJogo();
                break;
            case 2:
                ExibirJogos();
                break;
            case 3:
                AvaliarJogo();
                break;
            case 4:
                ExibirNotaMediaJogo();
                break;
        }
    }else{
        Console.WriteLine("\nVocê digitou uma opção invalida!");
        ExibirOpções();
    }

}

void ExibirTitulo(string titulo) 
{
    Console.Clear();
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void CadastrarJogo() 
{
    ExibirTitulo("CADASTRAR JOGO");
    Console.Write("Digite o nome do jogo: ");
    string jogoDigitado = Console.ReadLine()!;
    if (jogoDigitado == "")
    {
        Console.WriteLine("\nNão é possível cadastro o jogo em branco!");
        Thread.Sleep(3000);
        Console.Clear();
        CadastrarJogo();
    }
    else {
        colecaoDeJogos.Add(jogoDigitado, new List<int>());
        Console.WriteLine($"\nO jogo {jogoDigitado} foi cadastrado com sucesso!!!");
        Thread.Sleep(3000);
        ExibirOpções();
    }
}

void ExibirJogos()
{
    ExibirTitulo("EXIBIR TODOS OS JOGOS\n");

    if (colecaoDeJogos.Keys.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpções();
    }
    else {
        foreach (string jogo in colecaoDeJogos.Keys)
        {
            Console.WriteLine(jogo);
        }
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpções();
    } 
}

void AvaliarJogo() 
{
    ExibirTitulo("ATRIBUA UMA NOTA AO JOGO");
    if (colecaoDeJogos.Keys.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado para atribuir nota!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpções();
    }
    else
    {

        foreach (string jogo in colecaoDeJogos.Keys)
        {
            Console.WriteLine(jogo);
        }

        Console.Write("\nQual o jogo que deseja avaliar: ");
        string jogoDigitado = Console.ReadLine()!;

        if (colecaoDeJogos.ContainsKey(jogoDigitado))
        {
            Console.Write($"\nDigite a nota que deseja atribuir ao jogo {jogoDigitado}: ");
            int notaDigitada = int.Parse(Console.ReadLine()!);
            colecaoDeJogos[jogoDigitado].Add(notaDigitada);
            Console.WriteLine($"\nA nota {notaDigitada} foi registrada com sucesso!");
            Thread.Sleep(3000);
            ExibirOpções();

        }
        else
        {
            Console.WriteLine($"O jogo {jogoDigitado} não foi encontrado em sua coleção!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpções();
        }
    }
}

void ExibirNotaMediaJogo()
{
    ExibirTitulo("NOTA MÉDIA DO JOGO");
    if (colecaoDeJogos.Keys.Count == 0)
    {
        Console.WriteLine("Nenhum jogo cadastrado para exibir nota média!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpções();
    }
    else {

        foreach (string jogo in colecaoDeJogos.Keys)
        {
            Console.WriteLine(jogo);
        }
        Console.Write("\nDigite o nome do jogo que deseja exibir a média: ");
        string jogoDigitado = Console.ReadLine()!;

        if (colecaoDeJogos.ContainsKey(jogoDigitado)) {
            List<int> notasDoJogo = colecaoDeJogos[jogoDigitado];
            Console.WriteLine($"\n A média do jogo {jogoDigitado} é {notasDoJogo.Average()}");
            Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpções();
        }
        else
        {
            Console.WriteLine($"O jogo {jogoDigitado} não foi encontrado!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpções();
        }
    }
}

ExibirOpções();