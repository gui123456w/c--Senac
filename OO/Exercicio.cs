using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.OO {
    internal class Exercicio {
        public class Pessoa {
            protected readonly string Nome;
            protected readonly string Cpf;
            public Pessoa(string nome, string cpf) {
                Nome = nome;
                Cpf = cpf;

            }

            public string Apresentar() {
                return $"Olá, meu nome é {Nome} e meu CPF é {Cpf}.";
            }
        }
        public class Funcionario : Pessoa {
            protected readonly string Cargo;
            public Funcionario(string nome, string cpf, string cargo) : base(nome, cpf) {
                Cargo = cargo;
            }
        }
        public class Cliente : Pessoa {
            protected readonly string Email;
            public Cliente(string nome, string cpf, string email) : base(nome, cpf) {
                Email = email;
            }
        }



        public static void Executar() {
            var pessoa = new Pessoa("João", "123.456.789-00");
            var funcionario = new Funcionario("Maria", "987.654.321-11", "Desenvolvedora");
            var cliente = new Cliente("Neymar", "111.222.333-44", "neymar@email.com");

            Console.WriteLine(pessoa.Apresentar());
            Console.WriteLine(funcionario.Apresentar());
            Console.WriteLine(cliente.Apresentar());
        }
    }
}