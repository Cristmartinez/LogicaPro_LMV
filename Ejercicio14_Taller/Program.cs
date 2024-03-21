using System.Security.Cryptography;

namespace Ejercicio14_Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio pida 2 numeros y que muestre todos los numeros comprendidos entre ambos numeros incluyendolos 

            // Declaramos las variables

            double num1, num2, numMayor, numMenor;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            // Comparamos el numero mayor y el numero menor 

            if (num1 > num2)
            {
                numMenor = num2;
                numMayor = num1;

            }
            else 
            {
                numMayor = num2;
                numMenor = num1;


            }

            //cuenta los numeros desde el menor hasta el numero mayor de uno a uno
            for (double i = numMenor; i <= numMayor; i++ ) 
            {
                Console.WriteLine(i);

            }
            

        }
    }
}
