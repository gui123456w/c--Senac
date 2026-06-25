using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class VendaCelular {
        public string Cliente;
        public string Modelo;
        public double ValorCelular;
        public int Quantidade;

        public VendaCelular(string cliente, string modelo, double valorCelular, int quantidade) {
            Cliente = cliente;
            Modelo = modelo;
            this.ValorCelular = valorCelular;
            Quantidade = quantidade;
        }
        public double CalcularSubTotal() {
            return ValorCelular * Quantidade;
        }
        public double CalcularDesconto() {
            double total = CalcularSubTotal();
            if (total >= 3) {
                return total * 0.15;
            } else {
                return total * 0.05;
            }
        }
        public void mostrarOrdem() {
            Console.WriteLine($"CLiente: {Cliente}");
            Console.WriteLine($"Modelo {Modelo}");
            Console.WriteLine($"Valor das Peças {ValorCelular}");
            Console.WriteLine($"VQuantidade de celulares comprados {Quantidade}");
            //funções
            Console.WriteLine($"Total`{CalcularSubTotal()}");
            Console.WriteLine($"Desconto {CalcularDesconto()}");

            Console.WriteLine($"Valor FInal {CalcularDesconto()}");
        }
        internal class LojaCelulares {
            public static void Executar() {
                VendaCelular cliente1 = new VendaCelular("Neymar ", "Iphone ", 5000, 4);
                VendaCelular cliente2 = new VendaCelular("Endrick", "Positivo", 200, 1);
                VendaCelular cliente3 = new VendaCelular("Mbappe ", "Radio ", 20, 1);



                cliente1.mostrarOrdem();
                cliente2.mostrarOrdem();
                cliente3.mostrarOrdem();

            }
        }
    }
}