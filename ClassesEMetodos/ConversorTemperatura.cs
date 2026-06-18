using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCHsharp.ClassesEMetodos {
    class ConversorTemperatura {
        public double Celsius (double fahrenheit) {
            return (fahrenheit - 32) / 1.8;
        }
        public double Fahrenheit(double celsius) {
            return (celsius * 1.8) + 32;
        }
        public double CelsiusParaKelvin(double celsius) {
            return celsius + 273.15;
        }
        public double KelvinParaCelsius(double kelvin) {
            return kelvin - 273.15;
        }
    }
    internal class ConversosTemperatura {
        public static void Executar() {
            var conversor  = new ConversorTemperatura();

            var resultado = conversor.Celsius(100);
            
            
            var fahrenheit = conversor.Fahrenheit(0);

            var celsiusKelvin = conversor.CelsiusParaKelvin(0);

            var kelvinCelsius = conversor.KelvinParaCelsius(273.15);

            Console.WriteLine($"Conversão celsius para fahreheint {resultado}");

            Console.WriteLine($"Conversão fahrenheit para celsius {fahrenheit}");

            Console.WriteLine($"celsius para Kelvin {celsiusKelvin}");

            Console.WriteLine($"Kelvin para celsius {kelvinCelsius}");

        }
    }
}