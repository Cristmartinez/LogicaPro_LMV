using System.ComponentModel.Design;

namespace Ejercicio12ResolverEcuacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ecuacion Cuadratica de la forma ax^2 + bx + c = 0  donde a, b y c son coeficientes 
            // Formula General (-b+-raiz(b^2-4*a*c)/(2a)

            // Declaramos las Variables
            double a, b, c, X, X1, X2, operacion;
            String mensaje = "La solucion de la ecuacion es = ";

            Console.Write("Ingresar coeficiente A = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingresar coeficiente B = ");
            b = double.Parse((Console.ReadLine()));
            Console.Write("Ingresar coeficiente C = ");
            c = double.Parse((Console.ReadLine()));

            //Realizamos los calculos de la ecuacion con la formula general

            operacion = b * b - 4 * a * c;

            if (operacion > 0)
            {
                X1 = (-b + Math.Sqrt(operacion)) / (2 * a);
                X2 = (-b - Math.Sqrt(operacion)) / (2 * a);
                Console.WriteLine("Las soluciones Reales distintas para X1 = " + "{" + X1 + "}" + " y para X2 = " + "{" + X2 + "}");

            }
            else if (operacion == 0)
            {
                X = (-b / (2 * c));
                Console.WriteLine("Solucion doble:  x= " + "{" + X + "}");

            }
            else 
            {
               
                Console.WriteLine("No tiene solucion");     
            
            
            }

            Console.WriteLine("Operacion Matematica finalizada");
            Console.ReadLine();
                        
        }

    }
}
