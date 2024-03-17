namespace PrimerAlgoritmo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un algoritmo que pida N números por pantalla, cuando el usuario ingrese  un número negativo, el programa debe finalizar y mostrar en consola la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo.

            //Valores de entrada o Variables 


            int num, contador = 0;
            bool validador = true;

            // Creacion del Ciclo

            while (validador) // Banderea o Flag validador siempre es true
            {
                Console.Write("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                //si el numero es menor a cero muestra los numeros positivos ingresados
                if (num < 0 )
                {
                   validador = false;
                }
                else 
                { 
                   contador = contador + 1;


                }
            }
            Console.WriteLine(String.Format("El total de numeros positivos ingresados es de: {0}" , contador));
        }
    }
}
