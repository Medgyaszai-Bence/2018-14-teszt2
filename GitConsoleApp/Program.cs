using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg hány számot szeretne bekérni.");
            
            int bekeres = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[bekeres];

            Console.WriteLine("Kérem adjon meg {0} számot.", bekeres);

            int szamok;
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("Kérem adja meg az {0} számot", i+1);
                szamok = Convert.ToInt32(Console.ReadLine());
                t[i] = szamok;
                
            }
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            int max, min;

            max = t[0];
            min = t[0];
            for (int i = 1; i < t.Length; i++)

            {

                if (t[i] > max) max = t[i];
                if (t[i] < min) min = t[i];

            }
            Console.WriteLine("Legnagyobb szám: {0} \nLegkissebb szám: {1}", max,min);

        }
    }
}
