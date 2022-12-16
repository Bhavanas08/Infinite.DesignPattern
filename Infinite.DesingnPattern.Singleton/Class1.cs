using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inifinite.CSharp.Day3
    {
        internal class Example2
        {
            static void Main(string[] args)
            {
                int[,] arr = new int[5, 6];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter array numbers:");
                    for (int j = 0; j < 6; j++)
                    {
                        arr[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("The  array is:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(arr[i, j] + ",");
                    }
                    Console.WriteLine("\n");
                }


            }



        }
    }
}
}
