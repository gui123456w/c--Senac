using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class CadastroTorcedores {
        public static void Executar() {
            int total = 0;

            while (true) {

                Console.Write("Digite o nome do torcedor (ou 'fim' para encerrar): ");

                string nome = Console.ReadLine();


                if (nome.ToLower() == "fim") {

                    break;

                }
                Console.Write("Digite a seleção favorita: ");

                string selecao = Console.ReadLine();

                total++;
            }


            Console.WriteLine($"\nTotal de torcedores cadastrados: {total}");

        }
    }
}
