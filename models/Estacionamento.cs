using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SistemaEstacionamento.models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o valor total foi: R${valorTotal}");
            } else {
                Console.WriteLine($"Desculpa! veículo {placa} não encontrado.");
            }
        }

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");

                int contadorForeach = 1;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"Posição N° {contadorForeach} - Veículo: {placa}.");
                    contadorForeach++;
                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}