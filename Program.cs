using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int No;
            int [] intArray;
            Console.WriteLine("Enter value to find the prime no");
            No = Convert.ToInt32(Console.ReadLine());
            intArray = new int[No];
            for (int i=0;i<No;i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i < intArray.Length; i++)
            {
                Boolean isPrime = true;
                for (int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine("It is Prime:{0}",i);
                }

            }
            Console.Read();

        }
    }
}
