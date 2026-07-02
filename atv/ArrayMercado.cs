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
            double maiorPreco = precos[0];
            string produtoMaisCaro = produtos[0];

            for (int i = 1; i < precos.Length; i++) {
                if (precos[i] > maiorPreco) {
                    maiorPreco = precos[i];
                    produtoMaisCaro = produtos[i];
                }
            }
            
            double menorPreco = precos[0];
            string produtoMaisBarato = produtos[0];
            
            for(int i = 1; i < precos.Length; i++) {
                if (precos[i] < menorPreco) {
                    menorPreco = precos[i];
                    produtoMaisBarato = produtos[i];
                }
            }

            double somaPreco = 0;

            foreach (double preco in precos) {
                somaPreco += preco;
            }
            double media = somaPreco / precos.Length;

            Console.WriteLine($"Produtos cadastrado foi {produtos.Length} ");
            Console.WriteLine($"Total dos gastos no Mercado : {somaPreco:F2}");
            
           
            Console.WriteLine($"Produto com maior valor {produtoMaisCaro} e o valor é {maiorPreco}");
            Console.WriteLine($"Produto com menor valor {produtoMaisBarato} e o valor é {menorPreco}");
            Console.WriteLine($"Media foi dos produtos gastados foi de {media}");

        }
    }
}