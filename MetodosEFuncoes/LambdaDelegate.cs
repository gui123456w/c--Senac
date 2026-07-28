using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.MetodosEFuncoes {
    delegate double Operacao(double x, double y);
    internal class LambdaDelegate {

        public static void Executar() {
            Operacao soma = (x, y) => x + y;
            Operacao multi = (x, y) => x * y;
            Operacao subtracao = (x, y) => x - y;
            Operacao divisao = (x, y) => x / y;

            Console.WriteLine(soma(67,67));

        }
    }
}