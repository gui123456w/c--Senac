using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CursoCHsharp.Colecoes {
    internal class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            //adicionando elementos na pilha

            pilha.Push(3);
            pilha.Push("Neymar");
            pilha.Push(true);
            pilha.Push(3.14);


            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Pop: {pilha.Pop()}");
            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }



        }
    }   
}
