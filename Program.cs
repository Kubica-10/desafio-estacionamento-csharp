// --- PAINEL DE CONTROLE ---
// Este arquivo é o ponto de entrada do nosso programa. Ele é responsável por:
// 1. Pedir os dados iniciais (preços).
// 2. Criar o nosso estacionamento.
// 3. Exibir o menu de opções para o usuário.

// Pede ao usuário para digitar o preço inicial e guarda na variável 'precoInicial'.
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

// Pede o preço por hora.
Console.WriteLine("Agora digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

// A "mágica" acontece aqui!
// Estamos criando um objeto real a partir da nossa "planta" (a classe Estacionamento).
// 'es' é a nossa variável que representa o estacionamento em si, já com os preços definidos.
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Variável para manter o menu rodando.
bool exibirMenu = true;

// O laço 'while' vai continuar repetindo o menu enquanto a variável 'exibirMenu' for 'true'.
while (exibirMenu)
{
    // O 'Console.Clear()' limpa a tela do terminal a cada vez, para o menu aparecer sempre no topo.
    Console.Clear();
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    // O 'switch' é uma forma organizada de lidar com as escolhas do usuário.
    switch (Console.ReadLine())
    {
        case "1":
            // Se o usuário digitar "1", chama o método AdicionarVeiculo do nosso objeto 'es'.
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            // Se digitar "4", mudamos a variável para 'false', e o laço 'while' vai parar.
            exibirMenu = false;
            break;

        default:
            // Se digitar qualquer outra coisa.
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine(); // Pausa o programa até o usuário pressionar Enter.
}

Console.WriteLine("O programa se encerrou");