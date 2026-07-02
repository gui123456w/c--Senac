using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Colecoes {
    internal class ColecoesQueue {
        public static void Executar() { 
            var fila = new Queue<string>();

            fila.Enqueue("Neymar jr ");
            fila.Enqueue("Neymar Pleno ");
            fila.Enqueue("Neymar Sênior ");
            fila.Enqueue("Neymar Master ");


            //primeiro da fila peek
            Console.WriteLine(fila.Peek());
            //conta as pessoas na fila 
            Console.WriteLine(fila.Count);


            //remover primeiro da fila 
            Console.WriteLine(fila.Dequeue());

            Console.WriteLine(fila.Count);


            foreach(var pessoas in fila) {
                Console.WriteLine(pessoas);
            }

            Console.WriteLine("Chamando os pacientes: ");
            while(fila.Count > 0) {
                string proximo = fila.Dequeue();
                Console.WriteLine($"{proximo} foi atentido: ");
            }
        }
    }
}
