using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Colecoes {
    internal class Arrays {

        public static void Executar() {

            string[] jogadores = new string[5];
            jogadores[0] = "Neymar";
            jogadores[1] = "Rayan";
            jogadores[2] = "Endrick";
            jogadores[3] = "Vinicius Jr";
            jogadores[4] = "Casemiro";
            //percorrer o array

            foreach (var jogador in jogadores) {
                Console.WriteLine(jogador);           
            } 
        }
    }
}
