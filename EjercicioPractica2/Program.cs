namespace EjercicioPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Comparar si 2 numeros son iguales 

            double num1, num2;
            Console.WriteLine("Ingresa el Primer Numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo Numero");
            num2 = double.Parse(Console.ReadLine());
            //Comparamos Numeros
            if (num1 == num2) Console.WriteLine("Los Numeros Son iguales");
            else if (num1 > num2) Console.WriteLine("El numero " + num1 + "Es mayor");
            else Console.WriteLine("El numero " + num2 + " Es mayor");

            Console.ReadLine();
        }
    }
}
