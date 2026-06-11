using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class FaseCompeticao {
        public static void Executar() {
            Console.Write("Digite a quantidade de pontos da seleção: ");
            int pontos = int.Parse(Console.ReadLine());

            if (pontos >= 0 && pontos <= 3) {
                Console.WriteLine("Seleção Eliminada");
            } else if (pontos >= 4 && pontos <= 6) {
                Console.Write("Digite o saldo de gols da seleção: ");
                int saldoGols = int.Parse(Console.ReadLine());

                if (saldoGols > 3) {
                    Console.WriteLine("Classificada");
                } else {
                    Console.WriteLine("Repescagem");
                }
            } else if (pontos >= 7) {
                Console.WriteLine("Classificada diretamente");
            } else {
                Console.WriteLine("Pontuação inválida.");
            }

            Console.ReadKey();
        }
    }
}
