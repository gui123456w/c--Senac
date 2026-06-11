using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    internal class CamisaTime {
        public static void Executar() {
            Console.Write("Quantidade de camisas: ");
            int qtd = int.Parse(Console.ReadLine());

            double subtotal = qtd * 199.90;
            double desconto = 0;

            if (qtd >= 3 && qtd <= 5)
                desconto = subtotal * 0.05;
            else if (qtd > 5)
                desconto = subtotal * 0.10;

            double valorFinal = subtotal - desconto;

            Console.WriteLine($"Subtotal: R$ {subtotal:F2}");
            Console.WriteLine($"Desconto: R$ {desconto:F2}");
            Console.WriteLine($"Valor Final: R$ {valorFinal:F2}");
        }
    }

}
