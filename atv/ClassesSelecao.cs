using CursoCHsharp.atv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.atv {
    class Selecao {
        public string Pais;
        public string Continente;
        public int Titulos;

        public Selecao(string pais, string continente, int titulos) {
            Pais = pais;
            Continente = continente;
            Titulos = titulos;
        }

        public void Ganhar() => Titulos++;

        public void Perder() {
            if (Titulos > 0)
                Titulos--;
        }

        public void MostrarDados() {
            Console.WriteLine(
                $"País escolhido: {Pais} | Continente: {Continente} | Títulos: {Titulos}");
        }
    }
}

internal class ClassesSelecao {
    public static void Executar() {
        Selecao brasil = new Selecao("Brasil", "América do Sul", 5);

        brasil.Ganhar();
        brasil.MostrarDados();

        Selecao alemanha = new Selecao("Alemanha", "Europa", 4);

        alemanha.Ganhar();

        alemanha.MostrarDados();
    }
}