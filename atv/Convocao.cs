using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class Convocao {
        public static void Executar() {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de gols: ");
            int gols = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 35) {
                if (gols >= 20)
                    Console.WriteLine("Convocado");
                else
                    Console.WriteLine("Lista de espera");
            } else {
                Console.WriteLine("Não convocado");
            }
        }
    }
}
