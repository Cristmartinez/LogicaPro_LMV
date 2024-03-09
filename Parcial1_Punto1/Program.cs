namespace Parcial1_Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Un vendedor recibe un sueldo base de $1.000.000 y reciben una comision del 10% sobre el valor total de cada venta que realiza

            // Sueldo base del vendedor
            decimal sueldoBase = 1000000; // Sueldo base de $1,000,000

            // Ventas realizadas por el vendedor
            decimal[] ventas = { 300000, 400000, 350000 }; // Reemplaza con las ventas reales

            // Variables para realizar los cálculos
            decimal comisionTotal = 0;
            decimal totalMes = sueldoBase;
            decimal mayorComision = 0;
            decimal promedioComisiones = 0;

            // Calcula la comisión por cada venta y realiza otros cálculos
            for (int i = 0; i < ventas.Length; i++)
            {
                decimal comisionVenta = ventas[i] * 0.10m;
                comisionTotal += comisionVenta;
                totalMes += comisionVenta;

                // Verifica si esta venta generó la mayor comisión
                if (comisionVenta > mayorComision)
                {
                    mayorComision = comisionVenta;
                }

                // Calcula el promedio de las comisiones
                promedioComisiones += comisionVenta;
            }

            // Calcula el promedio de las comisiones
            promedioComisiones /= ventas.Length;

            // Verifica si el vendedor superó el objetivo de ventas
            decimal totalVentas = ventas[0] + ventas[1] + ventas[2];
            bool alcanzoObjetivo = totalVentas >= 1000000;

            // Aplica el beneficio extra si se alcanzó el objetivo
            if (alcanzoObjetivo)
            {
                totalMes += 100000;
            }

            // Muestra los resultados
            Console.WriteLine($"Comisiones por las tres ventas: ${comisionTotal}");
            Console.WriteLine($"Total recibido en el mes: ${totalMes}");
            Console.WriteLine($"Venta que generó la mayor comisión: ${mayorComision}");
            Console.WriteLine($"Promedio de comisiones por venta: ${promedioComisiones}");

            if (alcanzoObjetivo)
            {
                Console.WriteLine("¡Felicidades! Has ganado el beneficio extra de $100,000.");
            }
            else
            {
                Console.WriteLine("No has alcanzado el objetivo de ventas para el beneficio extra.");


            }
        }
    }
}
