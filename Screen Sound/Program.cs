// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//Lista
List<string> ListaDasBandas = new List<string> { "U2", "Beatles", "Resgate" };

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
             break;

        case 2: MostrarBandasRegistradas();
            break;

        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

//Função para registrar uma banda
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*******************");

    Console.Write("Digite o nome da banda para registarr: ");

    string nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);// Inserindo as bandas 

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada ");
    Thread.Sleep(2000);

    //Esperar o console e voltar para o menu principal
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("*******************");

    //Exibir bandas no console
    for (int i = 0; i < ListaDasBandas.Count; i ++)
    {
        Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    }

    Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();