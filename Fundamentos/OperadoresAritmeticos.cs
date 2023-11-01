using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar() {
            /*Console.WriteLine("Escolha um numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("EScolha outro numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre eles é {n1 + n2}");*/

            Console.WriteLine("Informe a altura do triângulo");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a base do triângulo");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A área do triângulo é {(n1*n2)/2}");
        }
    }
}
