using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    internal class MetodosEstatico {

        public static void Executar() {
            //diferença que não é necessário colocar no executar o new calculadora 
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Calculadora de multiplicação resultado é {resultado}");

            Console.WriteLine(CalculadoraEstatica.Somar(10,10));

        }
    }
}
