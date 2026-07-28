using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCHsharp.MetodosEFuncoes {
    internal class ExemploLambda {
        public static void Executar() {
            Action neymar = () => {
                Console.WriteLine("Hoje é NeyDay!");
            };

            neymar();

            Func<int> jogarDados = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDados());

            Func<int, int, int, string> formatarData = (dia, mes, ano) => {
                return string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            };

            Console.WriteLine(formatarData(05, 02, 1992));
        }
    }
}