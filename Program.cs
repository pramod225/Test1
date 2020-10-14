using System;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfArraySize;
            int[] NoPrime;
            int CountPrimeNO=0;
            int temp;
            Console.WriteLine("Enter the size of Array");
            NoOfArraySize = Convert.ToByte(Console.ReadLine());
            NoPrime = new int[NoOfArraySize];
            for(int i = 0; i < NoOfArraySize; i++)
            {
                NoPrime[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Array Element:");
            for(int i = 0; i < NoOfArraySize; i++)
            {
                Console.WriteLine(NoPrime[i]);
            }
            Console.WriteLine("Prime no in  the Array");
            for(int i = 0; i < NoOfArraySize; i++)
            {
                temp = 0;
                for(int j = 2; j < NoPrime[i] - 1; j++)
                {
                    if (NoPrime[i] % j == 0)
                    {
                        temp++;
                    }
                }
                if (temp== 0)
                {
                    CountPrimeNO++;
                    Console.WriteLine(NoPrime[i]);
                    

                }
               

            }
            Console.WriteLine("Total Prime no:" + CountPrimeNO);
            Console.Read();
        }
    }
}
