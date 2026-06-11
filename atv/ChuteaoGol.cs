using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class ChuteaoGol {
        public static void Executar() {
            Console.Write("Quantos chutes o jogador deu? ");
            int chutes = int.Parse(Console.ReadLine());

            Console.Write("Quantos gols o jogador marcou? ");
            int gols = int.Parse(Console.ReadLine());

            double aproveitamento = (double)gols / chutes * 100;

            Console.WriteLine($"Aproveitamento: {aproveitamento:F2}%");

            if (aproveitamento < 20) {
                Console.WriteLine("Resultado: Ruim");
            } else if (aproveitamento <= 50) {
                Console.WriteLine("Resultado: Bom");
            } else {
                Console.WriteLine("Resultado: Excelente");
            }
            Console.ReadKey();
        }

    }
}
