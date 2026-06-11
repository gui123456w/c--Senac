using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.EstruturasDeControles {
    internal class EstruturasIf {
        public static void Executar() {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18) {
                Console.WriteLine("Você pode ser preso");
            } else {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}
