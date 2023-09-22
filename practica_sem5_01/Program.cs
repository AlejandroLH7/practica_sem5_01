using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem5_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el multiplicando: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el multiplicador: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            int limite = numero2;

            if (numero2 <= 0) {            
                limite = -numero2;
            }
            for (int i = 0; i < limite; i++){ 
                resultado += numero1;
            }

            if ((numero1 <= 0) && (numero2 <= 0)){   
                resultado = - resultado;
            }
            Console.WriteLine($"El producto es {resultado}");
            Console.ReadKey();
        }
    }
}
