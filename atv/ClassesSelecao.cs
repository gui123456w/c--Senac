using CursoCHsharp.atv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    class Selecao {
        public string Pais;
        public string Continente;
        public int Titulos;

        public Selecao(string pais, string continente, int titulos) {
            Pais = pais;
            Continente = continente;
            Titulos = titulos;
        }

        public void Ganhar() {
            Titulos++;
        }

        public void Perder() {
            if (Titulos > 0)
                Titulos--;
        }

        public void MostrarDados() {
            Console.WriteLine(
                $"País: {Pais} | Continente: {Continente} | Títulos: {Titulos}");
        }
    }
    internal class ClassesSelecao {
        public static void Executar() {
            Selecao selecao = CriarSelecao();

            selecao.MostrarDados();

            selecao.Ganhar();
            Console.WriteLine("\nApós ganhar um título:");
            selecao.MostrarDados();

            selecao.Perder();
            Console.WriteLine("\nApós perder um título:");
            selecao.MostrarDados();
        }

        private static Selecao CriarSelecao() {
            Console.Write("Digite o país: ");
            string pais = Console.ReadLine();

            Console.Write("Digite o continente: ");
            string continente = Console.ReadLine();

            int titulos = LerTitulos();

            return new Selecao(pais, continente, titulos);
        }

        private static int LerTitulos() {
            int titulos;

            Console.Write("Digite a quantidade de títulos: ");

            while (!int.TryParse(Console.ReadLine(), out titulos)) {
                Console.Write("Valor inválido. Digite um número inteiro: ");
            }

            return titulos;
        }
    }
}