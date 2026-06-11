using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.EstruturasDeControles {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Escolha uma seleção ");
            Console.WriteLine("1- Brasil");
            Console.WriteLine("2- Argentina");
            Console.WriteLine("3- França");
            Console.WriteLine("4- Japão");
            Console.WriteLine("5- Panamá");
            Console.WriteLine("6- Espanha");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1: Console.WriteLine("Canarinho"); 
                    break;

                    case 2: Console.WriteLine("Gauchito"); 
                    break;
                    case 3: Console.WriteLine("Galo");
                    break;

                    case 4: Console.WriteLine("Yataganalha");
                    break;

                    case 5: Console.WriteLine("Canalha");
                    break;

                    case 6: Console.WriteLine("Toreiro");
                    break;
            }

        }
    }
}
