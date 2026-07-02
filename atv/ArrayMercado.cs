using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class ArrayMercado {
        public static void Executar() {
            string[] produtos = new string[5];
            double[] precos = new double[5];

            for (int i = 0; i < produtos.Length; i++) {
                Console.Write($"Informe o nome do {i + 1}º produto: ");
                produtos[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < precos.Length; i++) {
                Console.Write($"Informe o preço de {produtos[i]}: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }
                Console.WriteLine();
            for (int i = 0; i < produtos.Length; i++) {
                Console.WriteLine($"{produtos[i]} - R$ {precos[i]}");
            }

            double somaPreco = 0;

            foreach (double preco in precos) {
                somaPreco += preco;
            }
            Console.WriteLine($"Total dos gastos no Mercado : {somaPreco:F2}");

        }
    }
}
