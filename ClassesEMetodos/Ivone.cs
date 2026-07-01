using CursoCHsharp.EstruturasDeControles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class Aluno {
        public string nome { get; set; }
        public double nota { get; set; }
        public double nota1 { get; set; }
        public double media { get; set; }

        public string Nome {
            get {
                return nome.ToUpper();
            }
            set {
                nome = value;
            }
        }

        public double Nota {
            get {
                return nota;
            }
            set {
                if (value >= 0 && value <= 10) {
                    nota = value;
                } else {
                    Console.WriteLine("Nota inválida! Deve estar entre 0 e 10.");
                }
            }
        }
        public double Nota1 {
            get {
                return nota1;
            }
            set {
                if (value >= 0 && value <= 10) {
                    nota1 = value;
                } else {
                    Console.WriteLine("Nota inválida! Deve estar entre 0 e 10.");
                }
            }
        }
        public double Media {
            get {
                return (nota + nota1) / 2;
            }

        }


    }
    internal class Ivone {
        public static void Executar() {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            aluno.Nota = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine($"Nome do aluno é {aluno.nome}, Sua primeira nota {aluno.nota}, sua segunda nota é {aluno.nota1}, é media {aluno.Media}" );



            if(aluno.media >= 5) {
                Console.WriteLine("Aluno aprovado!");
            } else {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}