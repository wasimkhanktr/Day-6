using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no");
            int n = Convert.ToInt32(Console.ReadLine());
            int countFactors = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    countFactors++;
                }
            }
            if (countFactors == 2)
                Console.WriteLine(n +" is a Prime No");
            else
                Console.WriteLine(n +" is Not a Prime No");
        }
    }
}