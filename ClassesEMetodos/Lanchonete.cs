using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Lanchonete {
        public static void MontarPedido(params string[] combo) {
            Console.WriteLine("Seu pedido tem: ");
            foreach (string i in combo) {
                Console.WriteLine($"item: {i}");

            }
            Console.WriteLine($"Total de itens: {combo.Length} ");


        }
        public static void Executar() {
            List<string> itens = new List<string>();

            Console.WriteLine("Digite os itens do pedido> ");
            Console.WriteLine("Digite 'OK' para finalizar");

            while (true) {
                Console.WriteLine("Item: ");
                string item = Console.ReadLine();


                if (item == "ok") {
                    break;
                }
                itens.Add(item);

            }
            MontarPedido(itens.ToArray());
        }
    }
}