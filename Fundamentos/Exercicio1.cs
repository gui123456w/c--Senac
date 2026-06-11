using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Fundamentos {
    internal class Exercicio1 {
    
       public static void Executar() {
       
            const int MAX_JOGADORES = 26;

            Console.Write("Nome do jogador: ");
            string nome = Console.ReadLine();

            Console.Write("Idade do jogador: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Número da camisa: ");
            int camisa = int.Parse(Console.ReadLine());

            Console.Write("Salário mensal: R$ ");
            double salarioMensal = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de gols na temporada: ");
            int gols = int.Parse(Console.ReadLine());

            Console.Write("Ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("\n=== DADOS DO JOGADOR CONVOCADO ===");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Número da camisa: {camisa}");
            Console.WriteLine($"Salário mensal: {salarioMensal:C}");
            Console.WriteLine($"Gols na temporada: {gols}");
            Console.WriteLine($"Ano de nascimento: {anoNascimento}");
            Console.WriteLine($"Máximo de jogadores convocados: {MAX_JOGADORES}");

            double salarioAnual = salarioMensal * 12;

            DateTime dataNascimento = new DateTime(anoNascimento, 1, 1);

            Console.WriteLine("\n=== INFORMAÇÕES EXTRAS ===");
            Console.WriteLine($"Salário anual: {salarioAnual:C}");
            Console.WriteLine($"Salário anual (2 casas decimais): {salarioAnual:F2}");
            Console.WriteLine($"Data de nascimento: {dataNascimento:dd/MM/yyyy}");
        }

    }

}

