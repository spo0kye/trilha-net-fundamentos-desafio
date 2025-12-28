namespace DesafioFundamentos.Models
{
    public class Estacionamento
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
            // Implementado
            string placa;

            AdicionarVeiculo:
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            if(placa.Length >= 3)
            {
                veiculos.Add(placa);
                return;
            }
            else goto AdicionarVeiculo;

            /* Reescrito com boas práticas

            string placa = "";
            while(placa.Lenght < 3)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            }
            veiculos.Add(placa);

            */
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementado
            Console.WriteLine("Digite a placa do veículo remover:");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Implementado
                solicitarTempoEstacionado:
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    string tempoEstacionado = Console.ReadLine();
                    if (!int.TryParse(tempoEstacionado, out int horas)) goto solicitarTempoEstacionado;

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Implementado
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
                // Implementado
                Console.WriteLine("Os veículos estacionados são:");
                foreach(var veiculo in veiculos) Console.WriteLine(veiculo);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
