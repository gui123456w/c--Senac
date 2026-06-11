using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class ArtilheiroGols {
        public static void Executar() {
            string artilheiro = "";

            int maiorGols = -1;


            for (int i = 1; i <= 5; i++) {

                Console.Write($"Digite o nome do atleta {i}: ");

                string nome = Console.ReadLine();


                Console.Write($"Digite a quantidade de gols de marcados do atleta {nome}: ");

                int gols = int.Parse(Console.ReadLine());


                if (gols > maiorGols) {

                    maiorGols = gols;

                    artilheiro = nome;

                }

            }

            Console.WriteLine($"\nArtilheiro: {artilheiro} com {maiorGols} gols");
        }
    }
}
