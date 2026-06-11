using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.EstruturasDeControles {
    internal class EstruturaRepeticao {
        public static void Executar() {
            int contador = 1;
            int tentativas = 3;
            Console.WriteLine("Digite uma senha ");
            string password = Console.ReadLine();

            while (password != "7taz9hvj" && contador != 3 ) {
                Console.WriteLine($"Senha incorreta, digite novamente {tentativas-contador} tentativas "+ $"Digite senha novamente");
                password = Console.ReadLine();
            if (password == "7taz9Hvj") {
                Console.WriteLine("Senha correta! Bem-vindo à seleção de pontos!");
            } else {
                Console.WriteLine("Senha incorreta! Acesso negado.");
                    contador++;
                }
            }
        }
    }
}
/*
    Console.WriteLine("Digite a quantidade de torcedores:");
                int quantidade = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidade; i++) {
                    Console.WriteLine($"Torcedor {i} entrou no estádio");
                }
            }
        }
    }
*/
