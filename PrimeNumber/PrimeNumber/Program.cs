using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0, end = 0,i,j,flag;
            Console.WriteLine("Enter Start Number");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Prime Number Are : ");
            for (i = start; i <= end; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.Write(i+" ");
            }
            Console.WriteLine();

        }
    }
}
