using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Jogador {
        public string Nome;
        public string Selecao;
        public int NumeroCamisa;
        public string Continente;
        public string ComidaTipica;
        

        public string APresentar() {
            return string.Format($"Olá, meu nome é {Nome}, Seleção {Selecao} Numero da camisa do jogador é  {NumeroCamisa} continente representado pelo atleta {Continente} Comida da tipica do Brasil {ComidaTipica} m.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(APresentar());
        }

    }
}
