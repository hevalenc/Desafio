using System;

namespace Desafio
{
    class Program
    {
        static void Main()
        {
            double a = 0.0;
            double b = 20.1;
            double c = 5.1;

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);

            var x1 = ((-b) + raiz) / (2 * a);
            var x2 = ((-b) - raiz) / (2 * a);

            if(x1 != Double.NaN && x2 != Double.NaN){
                Console.WriteLine("Valor de X1: {0}", x1.ToString("N5"));
                Console.WriteLine("Valor de X2': {0}", x2.ToString("N5"));
            }
            else{
                Console.WriteLine("Impossível de Calcular");
            }

        }
    }
}
