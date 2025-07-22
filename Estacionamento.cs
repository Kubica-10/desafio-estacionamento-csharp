// using System.Collections.Generic;
// using System.Linq;

public class Estacionamento
{
    // --- MEMÓRIA DO ESTACIONAMENTO ---
    // Estes são os "campos" ou "variáveis" que vão guardar as informações vitais do nosso sistema.
    
    // Guarda o preço que é cobrado logo que o carro entra.
    private decimal precoInicial = 0;
    
    // Guarda o preço que será cobrado por cada hora que o carro ficar.
    private decimal precoPorHora = 0;
    
    // É uma lista que vai guardar a placa de todos os veículos que estão no estacionamento.
    // Usamos 'List<string>' porque é uma lista de textos (placas) que pode crescer e diminuir.
    private List<string> veiculos = new List<string>();

    // --- A "IGNIÇÃO" DO ESTACIONAMENTO ---
    // Este é o método "construtor". Ele é executado uma única vez, quando o estacionamento é criado.
    // Ele serve para definir os valores iniciais obrigatórios.
    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        // 'this.precoInicial' se refere à variável da "memória" da classe.
        // 'precoInicial' (sem o 'this') se refere ao valor que recebemos quando o estacionamento foi criado.
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    // --- AS "AÇÕES" DO ESTACIONAMENTO ---
    // Estes são os "métodos", as ações que nosso estacionamento pode realizar.

    public void AdicionarVeiculo()
    {
        // Pede para o usuário digitar a placa e a guarda na variável 'placa'.
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        
        // Adiciona a placa digitada à nossa lista de veículos.
        veiculos.Add(placa);
        
        // Confirma que a ação foi realizada.
        Console.WriteLine($"A placa {placa} foi cadastrada com sucesso!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        // O '.Any()' é um jeito esperto de verificar se a lista 'veiculos' contém ALGUM item.
        // A condição 'x.ToUpper() == placa.ToUpper()' verifica a placa digitada e a placa na lista
        // com letras maiúsculas, para não dar erro se o usuário digitar 'abc-1234' em vez de 'ABC-1234'.
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            // Lê as horas e converte o texto para um número inteiro.
            int horas = Convert.ToInt32(Console.ReadLine());
            
            // Calcula o valor total a ser pago.
            decimal valorTotal = precoInicial + (precoPorHora * horas); 

            // Remove a placa da nossa lista de veículos.
            veiculos.Remove(placa);

            // Exibe a mensagem final para o usuário.
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se existe algum veículo na lista 'veiculos'.
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            // 'foreach' é um laço de repetição que passa por cada item da lista.
            // A cada volta, o item atual é colocado na variável 'veiculo'.
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}