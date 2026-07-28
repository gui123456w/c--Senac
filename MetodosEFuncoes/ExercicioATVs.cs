using CursoCHsharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCHsharp.MetodosEFuncoes {
    internal class ExercicioATVs {
        public static void Executar() {
            Func<int, int, int> soma = (x, y) => x + y;
            
            Func<int,int> dobro = x => x * 2;

            Console.WriteLine($"Soma dos numeros foi {soma(10,4)}");

            Console.WriteLine($"Dobro dessa conta é {dobro(4)}");
        }
    }
}
