using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {

  
    internal class Animais {

        public string Nome;
        public string Especie;
        public string Cor;
        public int Idade;

        public Animais(string nome, string especie, string cor, int idade) {
            Nome = nome;
            Especie = especie;
            Cor = cor;
            Idade = idade;
        }

        public void APresentar() {
            Console.WriteLine($" Nome:{Nome} ");
            Console.WriteLine($"Especie: {Especie}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Idade: {Idade}");
        }
        public static void Executar() {
            Animais animais = new Animais(
                "Leopardo",
                "Panthera pardus",
                "Amarelo com manchas pretas",
                7
            );

            animais.APresentar();
        }
    }
 }
