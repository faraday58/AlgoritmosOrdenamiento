using System;
using OrdenaInternos;

namespace AlgoritmosOrdenamiento
{
    class Program
    {
        static void Main()
        {
            int[] A = { 5, 2, 7, 9, 1 };

            Interno inburbuja = new Interno();
            inburbuja.Burbuja(A);
            Console.WriteLine(inburbuja);


        }
    }
}
