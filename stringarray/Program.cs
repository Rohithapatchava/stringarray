using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[100];
            Console.WriteLine("enter the car name");
            for(int i=0;i<5;i++)
            {
                cars[i] = Console.ReadLine();
            
            }
            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine("cars{0}", cars[j]);
            }


        }
    }
}
