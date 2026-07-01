using CursoCHsharp.atv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {

    class Jogadores {
        public string Nome { get; set; }
        public string Selecao { get; set; }
        public int numeroCamisa { get; set; }

        public int gols { get; set; }

        public int NumeroCamisa {
            get {
                return numeroCamisa;
            }
            set {
                if (value >= 1 && value <= 99) {
                    numeroCamisa = value;
                } else {
                    Console.WriteLine("Número de camisa inválido! Deve estar entre 1 e 99.");
                }
            }
        }

        public int Gols {
            get {
                return Gols;
            }
            set {
                if (value >= 0) {
                    gols = value;
                } else {
                    Console.WriteLine("Número de gols inválido! Não pode ser negativo.");
                }
            }
        }
     }
    internal class Jogo {
        public static void Executar() { 
            Jogadores jogador =  new Jogadores();

            Console.WriteLine("Nome do Jogador");
            jogador.Nome = Console.ReadLine();

            Console.WriteLine("Seleção ");
            jogador.Selecao = Console.ReadLine();

            Console.WriteLine("Número da camisa ");
            jogador.NumeroCamisa = int.Parse(Console.ReadLine());


            Console.WriteLine("Quantidade de gols: ");
            jogador.gols = int.Parse(Console.ReadLine());



            Console.WriteLine($"Nome do jogador é {jogador.Nome}, Seleção representada {jogador.Selecao} Numero da camisa {jogador.NumeroCamisa} Quantidade {jogador.gols}");
        }
    }
}

