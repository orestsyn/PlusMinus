using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            string s = Console.ReadLine();
            string[] stringArray = s.Split(new char[] { ' ' });
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(stringArray[i]);
            }
            decimal positive_numbers = 0, negative_numbers=0, zero_numbers=0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) positive_numbers++;
                if (array[i] < 0) negative_numbers++;
                if (array[i] == 0) zero_numbers++;
            }
            decimal pos = positive_numbers / n;
            decimal neg = negative_numbers / n;
            decimal zero = zero_numbers / n;
            Console.WriteLine("{0:F6}\n{1:F6}\n{2:F6}", pos,neg,zero);
            Console.ReadKey();
        }
    }
}
