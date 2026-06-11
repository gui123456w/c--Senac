using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Digite o seu CVV");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("O CVV do seu cartão é ",codigo);

            double valor = 67.67676767;

            Console.WriteLine(valor.ToString("F1"));

            Console.WriteLine(valor.ToString("C"));

            Console.WriteLine(valor.ToString("#.###"));

            Console.WriteLine(valor.ToString("P"));
        }
    }
}
