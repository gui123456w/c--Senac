using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class LendaCopa {
        public static void Executar() {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Gols: ");
            int gols = int.Parse(Console.ReadLine());

            Console.Write("Assistências: ");
            int assistencias = int.Parse(Console.ReadLine());

            int pontuacao = (gols * 5) + (assistencias * 3);

            string classificacao;

            if (pontuacao >= 100)
                classificacao = "Lenda da Copa";
            else if (pontuacao >= 50)
                classificacao = "Craque";
            else if (pontuacao >= 20)
                classificacao = "Bom Jogador";
            else
                classificacao = "Reserva";

            Console.WriteLine("\n===== RELATÓRIO =====");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Gols: {gols}");
            Console.WriteLine($"Assistências: {assistencias}");
            Console.WriteLine($"Pontuação: {pontuacao}");
            Console.WriteLine($"Classificação: {classificacao}");
        }
    }
}