using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class ContaCliente {
        public string TitularConta;
        public double Saldo;

        public string Cpf;

        public ContaCliente(string titularConta, double saldo, string cpf) {
            TitularConta = titularConta;
            Saldo = saldo;
            Cpf = cpf;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }
        public void Sacar(double valor) {
            Saldo -= valor;
        }
        public void MostrarSaldo() {
            Console.WriteLine($"saldo de {TitularConta} é R$ {Saldo}");
        }
    }
    internal class ContaBancaria {
        public static void Executar() { 
            ContaCliente conta1 = new ContaCliente("Neymar", 6000.00, "173.456.689-30");
            ContaCliente conta2 = new ContaCliente("Caça Rato ", 10, "235.233.212-49");

            conta1.Depositar(2);
            conta1.Sacar(10);


            conta1.MostrarSaldo();

            conta2.Depositar(10.00000);
            conta2.Depositar(500);
            
    }
  }
}
