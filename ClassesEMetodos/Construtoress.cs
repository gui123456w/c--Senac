using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class Cliente {
        public string Nome;
        public int Idade;
        public string Cpf;
        public string Email;
        public string Endereco;

        public Cliente(string nome, int idade, string cpf, string email, string endereco) {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }
    }
    internal class Construtoress {
        public static void Executar() {
            var cliente1 = new Cliente("João Silva",
                30,
                "123.456.789-00",
                "guilhermesantosnascimento@gmail.com",
                "Vila Belmiro - Santos "
            );

            Console.WriteLine($"Qual é o CWW do {cliente1.Nome} ?" );
            Console.WriteLine($"Idade do cliente {cliente1.Idade}");
            Console.WriteLine($"Cpf do Cliente {cliente1.Cpf} ");
            Console.WriteLine($"Email do Cliente {cliente1.Email }");
            Console.WriteLine($"Endereço do cliente {cliente1.Endereco} ");
        }
    }
}