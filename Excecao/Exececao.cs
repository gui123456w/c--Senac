using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Excecao {
    internal class Exececao {
        public class Conta {
            private double Saldo;

            public Conta(double saldo) {
                Saldo = saldo;
            }


            public void Sacar(double valor) {
                if (valor > Saldo) {
                    throw new ArgumentException("Saldo insuficiente para realizar o saque.");
                }
                Saldo -= valor;
            }
        }
        public static void Executar() {
            var conta = new Conta(600);
            try {
                conta.Sacar(67000);
                Console.WriteLine("Valor retirado retirado com sucesso ");
            } catch(Exception ex ){
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado por utilizar nosso banco");
            }
        }
    }
}
