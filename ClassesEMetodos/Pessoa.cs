using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade; 
        public double Altura;
       
        public string APresentar() {
            return string.Format($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha altura é {Altura}m.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(APresentar());
        }

    }
}