using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {


    internal class Soma {

        public static int Somar(params int[] numeros ) {
            int total = 0;
            foreach (int i in numeros) {
                total += i;
            }
            return total;
        }
        public static void Executar() {
            int qtde = int.Parse(Console.ReadLine());

            int[] numeros = new int[qtde];
            for (int contador = 0; contador < qtde; contador++) {
                Console.WriteLine($"Quantos numeros vocÊ quer somar {contador+1} Número: ");
                numeros[contador] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A soma é {numeros}");
        }
    }
 }
            //Console.WriteLine(Somar(10,20,8,3,67));
            //Console.WriteLine(Somar(5,10,8));
