using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigestAndLowest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1 2 3 4 5";
            
            Console.WriteLine(HighAndLow(str));
            Console.ReadLine();
        }

        public static string HighAndLow(string numbers)
        {
            string[] result = numbers.Split(' ');
            int max = 0;
            int min = 0;
            int[] vs=new int[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                vs[i] = Convert.ToInt32(result[i]);  
            }

            for (int i = 0; i < vs.Length; i++)
            {
                 max = vs.Max();
                 min = vs.Min();
            }

            
            return $"{max} {min}"; 
        }

        public static string HighAndLow1(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
    }
}
