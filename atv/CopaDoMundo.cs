using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class CopaDoMundo {
        public static void Executar() {
            
            Console.WriteLine("Digite seu nome do jogador");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade ");
            double idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Tem lesão s/n ? ");
            string lesao = Console.ReadLine();


            if (idade >= 18 && lesao == "s") {
                Console.WriteLine($"{nome}, vc ta fora");
            } else {
                Console.WriteLine($"{nome}, Você pode representar brasil");
            }
        
        }
    }
}
