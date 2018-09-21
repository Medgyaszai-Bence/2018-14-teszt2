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
           
            Console.WriteLine("Kérem adjon meg 10 számot.");
            int[] t = new int[10];
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
            int max;
            max = t[0];
            for (int i = 1; i < t.Length; i++)

            {

                if (t[i] > max) max = t[i];

            }
            Console.WriteLine("Legnagyobb szám: {0}", max);

        }
    }
}
