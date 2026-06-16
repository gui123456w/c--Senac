using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
             

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Neymar";
            pessoa1.Idade = 34;
            pessoa1.Altura = 1.75;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Messi";
            pessoa2.Idade = 38;
            pessoa2.Altura = 1.70;

            pessoa1.ApresentarNoConsole();
            pessoa2.ApresentarNoConsole();

        }
    }
}
