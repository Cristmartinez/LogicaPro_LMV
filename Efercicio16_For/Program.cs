namespace Efercicio16_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // elabora un algoritmo que imprima los numeros del 1 al 100, que clacule la sima de toddos los numenros pares por un lado, y por otro, la de todos los impares 

            // declaracion de variables 

            int acomuladorPar = 0, acomuladorImpar = 0;

            for ( int i = 1 ; i <= 100; i++)
            {
                // mostrar los 100 primeros numeros
                Console.WriteLine(i);

                //Identificar para acomular para par o impar
                if (i % 2 == 0) acomuladorPar += i;
                else acomuladorImpar += i;

                //foma inversa 
                //if ( i % 2 != 0 ) acumuladorImpar += i ;
                //else acumuladorPar += i ;
                                            
            }

            Console.WriteLine("la suma de los pares es:" + acomuladorPar);
            Console.WriteLine("la suma de los impar es:" + acomuladorImpar);
        }
        

    }
}
