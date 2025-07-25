using System;
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public partial class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();

            if (ValidarPlaca(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"\nO veículo de placa {placa} foi estacionado.\n");
            }
            else
            {
                Console.WriteLine("\nA placa digitada não é válida. Certifique-se que atenda aos padrões: XXX-0000 ou XXX0X00.\n");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public static bool ValidarPlaca(string placa)
        {
            // Formato tradicional (AAA-9999) ou Mercosul (AAA9A99)
            var padraoPlaca = PlacaRegex();

            return padraoPlaca.IsMatch(placa);
        }

        [GeneratedRegex(@"^([A-Z]{3}-\d{4}|[A-Z]{3}\d[A-Z]\d{2})$")]
        private static partial Regex PlacaRegex();
    }
}
