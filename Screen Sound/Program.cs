// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
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
ExibirMensagemDeBoasVindas();


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 Para registrar uma banda");
    Console.WriteLine("Digite 2 Para listar todas as banda");
    Console.WriteLine("Digite 3 Para avaliar uma banda");
    Console.WriteLine("Digite 4 Para exibir a media de uma banda");
    Console.WriteLine("Digite -1 Para sair");

    // Capturar 
    Console.Write("\nDigite a sua opção Para sair");
    string opcaoEscolhida = Console.ReadLine()!;

    //Condição
    // Transformar para inteiro texto para int
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch (opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("Voce escolheu a opçao " + opcaoEscolhidaNumerica);
            break;

            case 2: Console.WriteLine("Voce escolheu a opçao " + opcaoEscolhidaNumerica);
            break;

            case 3: Console.WriteLine("Voce escolheu a opçao " + opcaoEscolhidaNumerica);
            break;

            case 4: Console.WriteLine("Voce escolheu a opçao " + opcaoEscolhidaNumerica);
            break;

            case -1: Console.WriteLine("Voce escolheu a opçao " + opcaoEscolhidaNumerica);
            break;

            default: Console.WriteLine("Opção invalida");
            break;
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

