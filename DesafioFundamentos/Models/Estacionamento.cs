using System.Data;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0m;
        private decimal precoPorHora = 0m;
        private List<string> veiculos = new List<string>();
      
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void dataserviço()
        {
            DateTime data = DateTime.Now;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine("Digite a placa do veículo para remover:");
           
            string placa = Console.ReadLine();

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 
                
                veiculos.Remove(placa);

                Console.WriteLine("");
                Console.WriteLine("----------------- Estacionamento DIO -----------------");
                Console.Write(data.ToShortDateString());
                Console.Write($" ------ Extrato de Serviço ----------- ");
                Console.WriteLine(data.ToShortTimeString());
                Console.WriteLine($"O veículo: {placa} foi removido com sucesso!");
                Console.WriteLine($"Valor da tarifa de estacionamento: {precoInicial:C}");
                Console.WriteLine($"Valor por tempo de utilização: {precoPorHora:C}");
                Console.WriteLine($"Tempo de utilização: {horas}");
                Console.WriteLine($"Valor total a pagar: {valorTotal:C}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Obrigado po utilizar o estacionamento DIO!");
                Console.WriteLine($"Agradeçemos a preferência!");
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(var veiculo in veiculos)
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
}
