using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Reciptor {

        public static void Executar() {

            Jogador jogador = new Jogador();{
                jogador.Nome = "Neymar";
                jogador.Selecao = "Brasil";
                jogador.NumeroCamisa = 10;
                jogador.Continente = "America do Sul";
                jogador.ComidaTipica = "Feijoada";



                jogador.ApresentarNoConsole();
            }
        }
    }
}
