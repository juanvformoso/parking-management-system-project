using ParkingSystem.Models;

// Habilita o encoding UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

Console.WriteLine("Digite o preço inicial:");
if (!decimal.TryParse(Console.ReadLine(), out decimal precoInicial))
{
    Console.WriteLine("Preço inicial inválido. O programa será encerrado");
    return;
}

Console.WriteLine("Agora digite o preço por hora:");
if (!decimal.TryParse(Console.ReadLine(), out decimal precoPorHora))
{
    Console.WriteLine("Preço por hora inválido. O programa será encerrado");
    return;
}

// Instancia a classe estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("Encerrando o programa...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadKey();
}

Console.WriteLine("O programa se encerrou.");
