using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            int flag = 1;

            for(int i=2; i<number; i++)
            {
                if(number % i == 0)
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1 && number != 1)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            ArrayList primes = new ArrayList();
            Console.WriteLine("Please enter 10 number to query its primality: ");

            for(int i=0; i<10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if(IsPrime(number)
                    )
                    primes.Add(number);
            }
            Console.Write("Primes in your numbers: ");
            foreach(int p in primes)
            {
                Console.Write(p + " ");
            }

            Console.ReadKey();
        }
    }
}
