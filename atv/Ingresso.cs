using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class Ingresso {
        public static void Executar() {
            Console.WriteLine("Digite o valor do ingresso:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do comprador:");
            int idade = int.Parse(Console.ReadLine());

            if (valor >= 120 && idade >= 18) {

                Console.WriteLine("Ingresso comprado com sucesso!");

                if (valor >= 600) {
                    double desconto = valor * 0.05;
                    double valorFinal = valor - desconto;

                    Console.WriteLine($"Desconto de R$ {desconto:F2}");
                    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
                } else {
                    Console.WriteLine("Compra abaixo de R$600, sem desconto.");
                }

            } else if (valor < 120) {
                Console.WriteLine("Valor do ingresso insuficiente.");
            } else if (idade < 18) {
                Console.WriteLine("Comprador menor de idade. Ingresso não permitido.");
            }
        }
    }
}
