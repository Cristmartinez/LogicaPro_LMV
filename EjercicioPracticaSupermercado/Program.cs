using System.Timers;

namespace EjercicioPracticaSupermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En un supermercado se aplican descuentos a los clientes a su compra final tomando como referencia las siguientes reglas. 1 si la compra es igual o superior a $500, se le aplicara un descuento del 30% 2 Si la compra es igual o superior a $300, se le aplicara un descuento del 20% 3 Si la compra no supera los $300, se le aplicara un descuento del 10% 4 Se le aplicara un descuento extra si el cliente es mujer y mayor o igual a 50 años 5 Se le aplicara un descuento extra si el cliente es hombre mayoy o igual a 60 años.

            //declaramos las variables 

            double compra;
            int edad;
            String Genero;

            Console.WriteLine(" Ingresa el Valor de tu Compra"); 
            compra = double.Parse(Console.ReadLine());

            // Reglas de Descuentos segun el valor de la compra 

            if (compra >= 500) Console.WriteLine("Tienes el descuento del 30%");

            if (compra >= 300 && compra < 500) Console.WriteLine("Tienes el descuento del 20%");

            if (compra < 300) Console.WriteLine("Tienes el descuento del 10%");

            // Ahora aplicamos la regla segun el genero y edad 

            Console.WriteLine("Digita m si eres mujer o h si eres Hombre"); 
            Genero = Console.ReadLine();

            if (Genero == "m")
            {
                Console.WriteLine("¿ Que Edad Tienes?");
                edad = Convert.ToInt32(Console.ReadLine());
                if ((edad >= 50)) Console.WriteLine("Tienes un 10% descuento Extra");
                else Console.WriteLine("Lo siento no aplicas para el descuento adicional");
            }
            if (Genero == "h")
            {
                Console.WriteLine("¿ Que Edad Tienes?");
                edad = Convert.ToInt32(Console.ReadLine());
                if ((edad >= 60)) Console.WriteLine("Tienes un 10% descuento Extra");
                else Console.WriteLine("Lo siento no aplicas para el descuento adicional");
            }
            Console.WriteLine(" Gracias por tu Compra");    
            Console.ReadLine();
        }
    }
}
