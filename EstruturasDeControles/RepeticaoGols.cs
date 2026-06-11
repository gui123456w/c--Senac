using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.EstruturasDeControles {
    internal class RepeticaoGols {
        public static void Executar() {
            Console.WriteLine("Digite a quantidade de gols marcados:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++) {
                Console.WriteLine($"Gol {i} marcado!");
            }
        }
    }
}
