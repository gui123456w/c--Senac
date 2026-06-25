using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Pizzaria {

        public static void MontarPizza(params string[] ingredientes) {
            Console.WriteLine("\nSua pizza terá " + ingredientes.Length + " ingredientes:");

            foreach (string ingrediente in ingredientes) {
                Console.WriteLine(" - " + ingrediente);
            }
        }

        public static void Executar() {
            List<string> ingredientes = new List<string>();

            Console.WriteLine("Digite os ingredientes da pizza:");
            Console.WriteLine("Digite 'fim' para finalizar.");

            while (true) {
                Console.Write("Ingrediente: ");
                string ingrediente = Console.ReadLine().Trim();

                if (ingrediente.ToLower() == "fim") {
                    break;
                }

                if (ingrediente == "") {
                    Console.WriteLine("Ingrediente inválido! Digite novamente.");
                    continue;
                }

                ingredientes.Add(ingrediente);
            }

            if (ingredientes.Count == 0) {
                Console.WriteLine("Nenhum ingrediente foi adicionado.");
                return;
            }

            MontarPizza(ingredientes.ToArray());
        }
    }
}