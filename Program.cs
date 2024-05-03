using SistemaEstacionamento.models;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Bem-vindo ao sistema de estacionamento \n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar sistema");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        
        case "2":
            es.RemoverVeiculo();
            break;
        
        case "3":
            es.ListarVeiculo();
            break;
        
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Presione ENTER para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou!");