using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaBigDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe el numero de veces ");
            int n = Int32.Parse(Console.ReadLine());
            String[] s = new String[n + 2];

            for (int x = 0; x < n; x++)
                s[x] = Console.ReadLine();

            int i, j;
            String aux;
            for (i = 0; i < s.Length; i++)
            {
                for (j = 0; j < s.Length; i++)
                {
                    if (Int32.Parse(s[j+1]) < Int32.Parse(s[j]))
                    {
                        aux = s[j + 1];
                        s[j + 1] = s[j];
                        s[j] = aux; 
                    }
                }
            }

            for (int m = s.Length; m >= 0; m--)
                Console.WriteLine(Convert.ToDouble(s[m]));
        }
    }
}
