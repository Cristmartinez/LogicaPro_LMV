namespace LogicaPro_LMV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");

            // Se utiliza TryParse para manejar la posibilidad de que el usuario ingrese algo que no sea un número
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Verificar si el número es par o impar
                string resultado = (numero % 2 == 0) ? "par" : "impar";

                Console.WriteLine($"El número {numero} es {resultado}.");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
        }
    }
}
