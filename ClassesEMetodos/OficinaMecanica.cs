using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class OrdemServico {
        public string Cliente;
        public string Modelo;
        public double ValorPecas;
        public double ValorMaoDeObra;


        public OrdemServico(string cliente, string modelo, double valorPecas, double valorMaoDeObra) {
            Cliente = cliente;
            Modelo = modelo;
            ValorPecas = valorPecas;
            ValorMaoDeObra = valorMaoDeObra;
     
        }
        public double CalcularTotal() {
            return ValorPecas + ValorMaoDeObra;
        }
        public double CalcularDesconto() {
            double total = CalcularTotal();
            if(total >= 6.767) {
                return total * 0.67;
            } else {
                return total * 0.05; 
            }

        }
        public void mostrarOrdem() {
            Console.WriteLine($"CLiente: {Cliente}");
            Console.WriteLine($"Modelo {Modelo}");
            Console.WriteLine($"Valor das Peças {ValorPecas}");
            Console.WriteLine($"Valor do mão de Obra {ValorMaoDeObra}");
            //funções
            Console.WriteLine($"Total`{CalcularTotal()}");
            Console.WriteLine($"Desconto {CalcularDesconto()}");

            Console.WriteLine($"Valor FInal {CalcularDesconto()}");



        }

    }
    internal class OficinaMecanica {
        public static void Executar() {
            OrdemServico servico1 = new OrdemServico("Neymar", "McLaren", 1000, 10);
            OrdemServico servico2 = new OrdemServico("Júnior", "Porsche", 5000, 67000);

            servico1.mostrarOrdem();
            servico2 .mostrarOrdem();


        }
    }
}
