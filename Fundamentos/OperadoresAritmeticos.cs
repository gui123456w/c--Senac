using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {

            /*
            Console.WriteLine("Digite calculo da base");
            double baseNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite calculo da altura ");
            double altura = double.Parse(Console.ReadLine());

            double area = (baseNum * altura) / 2;
            Console.WriteLine(area); 
            */


            int a = 10;
            int b = 20;
            int c = 42;
            int d = 14;


            Console.WriteLine(c >= b);

            Console.WriteLine(d < b );

            Console.WriteLine(a == b && d <= b);

            Console.WriteLine(a > d || c != d);

        }
    }
}
