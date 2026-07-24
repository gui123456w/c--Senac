using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.OO {
    public abstract class Itembase {
            public string Nome { get; set; }
            public string Raridade { get; set; }

            private int _durabilidade;
            private int _precoMoedas;

            public int Durabilidade {
                get { return _durabilidade; }
                set {
                    if (value < 0)
                        _durabilidade = 0;
                    else if (value > 100)
                        _durabilidade = 100;
                    else
                        _durabilidade = value;
                }
            }
            public int PrecoMoedas {
                get { return _precoMoedas; }
                set {

                }
            }
        protected Itembase(int precoMoedas) {
            PrecoMoedas = precoMoedas;
        }

        public void Reparar() {
            Durabilidade = 100;
            PrecoMoedas = 2;
        }
        public static void Executar() {
            Itembase item = new Espada(50);
            item.Nome = "Espada de Ferro";
            item.Raridade = "Comum";
            item.Durabilidade = 80;
            Console.WriteLine($"Item: {item.Nome}, Raridade: {item.Raridade}, Durabilidade: {item.Durabilidade}, Preço: {item.PrecoMoedas} moedas");
        }

        private class Espada(int precoMoedas) : Itembase(precoMoedas) {
        }
    }
}