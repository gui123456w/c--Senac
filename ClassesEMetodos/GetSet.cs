using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class NovoCliente {
        private string _nome;

        public string Nome {
            get {
                return _nome;
            }
            set {
                _nome = value;
            }
        }
    }
    internal class GetSet {
        public static void Executar() {
            NovoCliente cliente1 = new NovoCliente();
            cliente1.Nome = "Neymar Jr";
            Console.WriteLine(cliente1.Nome);

        }
    }
}
