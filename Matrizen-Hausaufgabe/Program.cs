using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizen_Hausaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            int dimension1, dimension2, i=0;
            Console.Write("Dimensionsgröße eingeben: ");
            dimension1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dimensionsgröße eingeben: ");
            dimension2 = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[dimension1, dimension2];
            for(int x= 0; x < dimension2; x++)
            {
                for(int y =0; y < dimension1; y++)
                {
                    matrix[x, y] = i * i;
                    i++;
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine("");
            }


            //Collections
            int digits = 0, teilbar = 0;
            Random rnd = new Random();
            var collection = new List<int>();
            for(int z = 0; z < 100; z++)
            {
                collection.Add(rnd.Next());
            }
            for( int z = 0; z < collection.Count(); z++)
            {
                if(collection[z].ToString().Length == 3)
                {
                    digits++;
                }
                if (collection[z] % 7 == 0)
                {
                    teilbar++;
                }
            }

            Console.WriteLine("Anzahl der Zahlen mit 3 Stellen: " + digits);
            Console.WriteLine("Anzahl der Zahlen die ohne Rest durch 7 teilbar sind: " + teilbar);

            Console.ReadKey();
        }
    }
}
