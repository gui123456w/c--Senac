using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Excecao {
    internal class IngressoShow {
        public class Ingresso {
            private int QuantidadeDisponivel;

            public Ingresso(int quantidadeDisponivel) {
                QuantidadeDisponivel = quantidadeDisponivel;
            }

            public void Comprar(int quantidade) {
                if (quantidade > QuantidadeDisponivel) {
                    throw new ArgumentException("Quantidade de ingressos insuficiente para realizar a compra.");
                }
                QuantidadeDisponivel -= quantidade;
            }
            

        }
        public static void Executar() {
            Console.Write("Quantidade de Ingressos comprados");
            int quantidade = int.Parse(Console.ReadLine());

            var ingresso = new Ingresso(10);
            try {
                ingresso.Comprar(quantidade);
                Console.WriteLine($"Compra realidados com sucesso  ");
            } catch (Exception ex) {
                Console.WriteLine($"Erro ao comprar ingresso: {ex.Message}");
            } finally {
                Console.WriteLine("Processo de compra finalizado.");
            }
        }
    }
}
