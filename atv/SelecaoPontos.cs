using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class SelecaoPontos {
        public static void Executar() {
            
            Console.WriteLine("Quantidade de jgoos: ");
            int jogos = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= jogos; i++) {
                Console.WriteLine($"Pontos do jogo {i}: ");
                int pontos = int.Parse(Console.ReadLine());
                soma += pontos;
            }
            Console.WriteLine($"soma de todos os jogos {jogos} = ");
        }

    }
}
