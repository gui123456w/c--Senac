using CursoCHsharp.atv;
using CursoCHsharp.EstruturasDeControles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCHsharp.OO {
    internal class Carro {
        public class Veiculo {
            protected readonly int VelocidadeMaxima;
            protected int VelocidadeAtual;

            public Veiculo(int velocidadeMaxima) {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAtual + delta;

                if (novaVelocidade < 0) {
                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAtual = VelocidadeMaxima;
                } else {
                    VelocidadeAtual = novaVelocidade;
                }
                return VelocidadeAtual;
            }

            public int Acelerar() {
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }
        }

        // Gol herda de Veiculo, não de Carro
        public class Gol : Veiculo {
            public Gol() : base(200) {
            }
        }

        public static void Executar() {
            Console.WriteLine("Gol...");

            Gol carro1 = new Gol();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
        }
    }     
}
