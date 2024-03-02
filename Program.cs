namespace LogicaPro_LMV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int numero3 = int.Parse(Console.ReadLine());

            // Determinar el mayor de los tres números
            int mayor = Math.Max(numero1, Math.Max(numero2, numero3));

            Console.WriteLine($"El mayor número ingresado es: {mayor}");
        }
    }
    
}
