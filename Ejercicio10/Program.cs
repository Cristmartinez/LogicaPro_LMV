using System.ComponentModel.Design;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Preguntar al usuario si quiere una pizza vegetariana
            Console.WriteLine("¿Desea una pizza vegetariana? (s/n): ");
            char respuesta = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Definir ingredientes base comunes a todas las pizzas
            string ingredientesComunes = "mozzarella y tomate";

            // Mostrar menú de ingredientes según la elección del usuario
            string ingredientesAdicionales = "";
            if (char.ToLower(respuesta) == 's')
            {
                // Pizza vegetariana
                Console.WriteLine("Ingredientes vegetarianos disponibles: Pimiento y Tofu");
                Console.WriteLine("Elige un ingrediente adicional: ");
                string ingredienteElegido = Console.ReadLine();
                ingredientesAdicionales = $"Pimiento, Tofu y {ingredienteElegido}";
            }
            else
            {
                // Pizza no vegetariana
                Console.WriteLine("Ingredientes no vegetarianos disponibles: Peperoni, Jamón y Salmón");
                Console.WriteLine("Elige un ingrediente adicional: ");
                string ingredienteElegido = Console.ReadLine();
                ingredientesAdicionales = $"Peperoni, Jamón, Salmón y {ingredienteElegido}";
            }

            // Mostrar la información final de la pizza
            Console.WriteLine("Tu pizza elegida es:");
            Console.WriteLine($"Ingredientes: {ingredientesComunes}, {ingredientesAdicionales}");
            Console.WriteLine($"Es una pizza {(char.ToLower(respuesta) == 's' ? "vegetariana" : "no vegetariana")}.");

            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
        }
    }
}