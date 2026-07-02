using CursoCHsharp.EstruturasDeControles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCHsharp.Colecoes {
    internal class Arrays {

        public static void Executar() {

            /*string[] jogadores = new string[5];
            jogadores[0] = "Neymar";
            jogadores[1] = "Rayan";
            jogadores[2] = "Endrick";
            jogadores[3] = "Vinicius Jr";
            jogadores[4] = "Casemiro";
            //percorrer o array
            foreach (var jogador in jogadores) {
                Console.WriteLine(jogador);           
            }
            Console.WriteLine(jogadores[0]);
            */

            string[] nomes = new string[5];

            double[] notas = new double[5];

     
            for (int i = 0; i < nomes.Length; i++) {
                Console.Write($"Informe o nome do {i + 1}º aluno: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine();

     
            for (int i = 0; i < notas.Length; i++) {
                Console.Write($"Informe a nota de {nomes[i]}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            double somaNotas = 0;

            foreach (double nota in notas) {
                somaNotas += nota;
            }

            double totalNotas = somaNotas / notas.Length;

  
            Console.WriteLine("Lista de alunos e notas:");

            for (int i = 0; i < nomes.Length; i++) {
                Console.WriteLine($"{nomes[i]} - Nota: {notas[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"Soma das notas: {somaNotas}");
            Console.WriteLine($"Quantidade de alunos: {notas.Length}");
            Console.WriteLine($"Média da turma: {totalNotas:F2}");
        }
    }   
}   