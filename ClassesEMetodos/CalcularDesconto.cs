using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class Calculadora { 
        public static double Desconto(double preco, double percentual) {
            return preco - (preco  * percentual / 100);
        }

    }
    internal class CalcularDesconto {
        public static void Executar() {
            double precoProduto = 67.00;
            double percentualDesconto = Calculadora.Desconto(precoProduto, 10);
            Console.WriteLine($"Preço original R${precoProduto}" );
            Console.WriteLine($"Preço com desconto: R${percentualDesconto} ");
        }
    }
}
