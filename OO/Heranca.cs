using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.OO {

    internal class Heranca {
        public class Animal {
            public class Nome : Animal {
                public void Comer() {
                    Console.WriteLine("Animal está comendo");
                }
            }

            public class Cachorro : Animal {
                public void Latir() {
                    Console.WriteLine("Cachorro latindo");
                }
            }
            public class Gato : Animal {
                public void Miado() {
                    Console.WriteLine("Gato miando");
                }
            }
        }
        public class Transporte {
            public void Iniciar() {
                Console.WriteLine("Transporte iniciado");
            }
        }
        public class Bicicleta : Transporte {
            public void Pedalar() {
                Console.WriteLine("Bike está pedalando");
            }
        }


        public static void Executar() { 
            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Iniciar();
            bicicleta.Pedalar();

            Animal.Nome comer = new Animal.Nome();
            comer.Comer();

            Animal.Cachorro cachorro = new Animal.Cachorro();
            cachorro.Latir();


            Animal.Gato gato = new Animal.Gato();
            gato.Miado();

        }
    }
}
