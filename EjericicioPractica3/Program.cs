namespace EjericicioPractica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Supermercado Si la compra es mayor a 500 se le otorgara el 30% de descuento, si la compra es mayor o igual a 300 se le asignara el 20% de descuento y si la compra es menor a 300 se le asignara un 10% de descuento, si el cliente que compra es mujer y tiene mayor a 50 años se le asignara un 10% descuento adicional, y si el cliente es hombre y tiene mayor a 60 años se le aplicara un descuento del 10% 
            // Declaramos las variables
            double compra;
            double edad;
            String genero;

            // Solicitamos valor de la compra

            Console.WriteLine("Ingresa el valor de la compra: ");
            compra = double.Parse(Console.ReadLine());

            //Regla 1 segun valor de compra aplican los descuentos 30% 20% ó 10%

            if ((compra >= 500)) Console.WriteLine("Felicitaciones tienes un 30% de Descuento");
            else if ((compra >= 300 && compra < 500)) Console.WriteLine("Felicitaciones tienes un 20% de Descuento");
            else Console.WriteLine("Felicitaciones tienes un 10% de Descuento");

            Console.WriteLine("¿Cual es tu Genero?\nm - Si eres Mujer\nh - si eres Hombre");
            genero = Console.ReadLine();

            if ((genero == "m"))
            {
                Console.WriteLine("¿Que edad Tienes?");
                edad = double.Parse(Console.ReadLine());
                if (edad >= 50) Console.WriteLine("Tienes un Descuento Adicional del 10%");
                else Console.WriteLine("Lo siento no aplicas para el descuento");
            }
            if ((genero == "h"))
            {
                Console.WriteLine("¿Que edad Tienes ? ");
                edad = double.Parse((Console.ReadLine()));
                if (edad >= 60) Console.WriteLine("Tienes un Descuento adicional del 10%");
                else Console.WriteLine("Lo siento no aplicas para el descuento");
            }
            Console.WriteLine("Gracias Por tu compra");
            Console.ReadLine();



              
            


            
        }
    }
}
