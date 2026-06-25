using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    internal class Produto1 {
        public string Nome { get; set; }
        private double preco { get; set; }
        public double Desconto { get; set; }
        private double precoFinal { get; set; }
        public int EstoqueMinimo { get; set; }

        public double Preco { 
            get{
                return preco;
             }
            set {
                if(value >= 0) {
                    preco = value;
                } else {
                    Console.WriteLine("O preço não pode ser negativo ");
                }
            }
        }
        public double PrecoFinal {
            get {
                return preco - (Preco * Desconto / 100 ) ;
            }
        }
        public static void Executar() {
           Produto1 produto1 = new Produto1();
            produto1.Nome = "Chuteira do Neymar";
            produto1.Preco = 500;
            produto1.Desconto = 10;
            produto1.EstoqueMinimo = 5;

            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
        }
    }
}
