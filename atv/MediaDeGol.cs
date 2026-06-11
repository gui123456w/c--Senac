using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class MediaDeGol {
        public static void Executar() {
           
           int soma = 0;


            for(int i = 1; i <= 5; i++) {
                Console.WriteLine($"Digite os gols marcados em 5 partidas {i} ");
                int gols = int.Parse(Console.ReadLine());

                soma += gols;
            }
            double media = soma / 5.0;

            Console.WriteLine($"Media de gols {media}");
        }
    }
 }
