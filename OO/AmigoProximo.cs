using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamentoo {
    internal class AmigoProximo {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo...");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDoOlho); // protected
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoFamilia); // private protected
        }
    }
}