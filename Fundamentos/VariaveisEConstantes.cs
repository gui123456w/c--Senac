using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //variável é um espaço na memória para armazenar um valor que pode ser alterado durante a execução do programa
            double raio = 4.5;

            //constante é um valor que não pode ser alterado depois de definido
            const double pi = 3.14;

            double area = pi * raio * raio;
            Console.WriteLine("A área total é"+area);
            
            int idade = 0;

            bool temNeymar = false;

            var nome = "Neymar";

            byte idadeNeymar = 34; //0 a 255
            sbyte saldo = -10; //-128 a 127

            uint salarioNeymar = 1000000000; //0 a 4.294.967.295

            long salarioRealNey = 1000000000000000000; // -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            ulong salarioRealVerdadeiroNey = 10000000000000000000; //0 a 18.446.744.073.709.551.615
            

            DateTime dataNascimento = new DateTime(1992, 02, 05);

            Console.WriteLine("A área total é" + area);
            Console.WriteLine($"Neymar ganha {salarioRealVerdadeiroNey}");
        }
    }
}
