using System.ComponentModel.Design;

namespace EjercicioPractica4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Definimos variables 

            String Seleccionvegetarianos = "Pimiento y tofu";
            String Seleccionnovegetarianos = "Peperoni, jamon y salmon";
            String Si;
            String No;
            String IngredienteComun = "Mozarella y Tomate";
            String Tofu = "Tofu";
            String Pimiento = "Pimiento";
            String Peperoni = "Peperoni";
            String jamon = "jamon";
            String Salmon = "Salmon";

            //Preguntar a cliente que pizza quiere 

            Console.WriteLine("¿Desea una pizza Vegetariana?\nS - Si \nN - No");
            No = Console.ReadLine();

            if (No == "N")
            {
                Console.WriteLine("Estos son los ingredientes que vienen en nuestras pizzas son: " + IngredienteComun);
                Console.WriteLine("\nAdicional a estos puedes escoger un ingrediente mas entre: " + Seleccionnovegetarianos);
                Console.WriteLine("Seleccione el ingrediente que desees:\nP - Peperoni\nJ - Jamon\nS- Salmon");
                Peperoni = Console.ReadLine();
                
                if (Peperoni == "P") Console.WriteLine(" Felicitaciones tu Pizza " + IngredienteComun + " y "  + Peperoni +  "Esta Siendo Preparada");
                else if (Peperoni == "J") Console.WriteLine("Felicitaciones tu Pizza" + IngredienteComun + " y "  + jamon +  "Esta Siendo Preparada");
                else Console.WriteLine("Felicitaciones tu Pizza" + IngredienteComun + " y "  + Salmon +  "Esta Siendo Preparada");
                
            }
            else
            {
                Console.WriteLine("Estos son los ingredientes que vienen en nuestras pizzas son: " + IngredienteComun);
                Console.WriteLine("\nAdicional a estos puedes escoger un ingrediente mas entre: " + Seleccionvegetarianos);
            }
        
                
                
        }
    }
}
