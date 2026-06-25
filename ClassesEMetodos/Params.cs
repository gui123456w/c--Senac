using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Params {
        public static void Recepionar(params string[] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }

        }
        public static void Executar() {
            Recepionar("Serena", "Arthur", "Murilo", "Luan ");
        }
    }
}
