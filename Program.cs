using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int k = height - i - 1; k >= 0; k--)
                {
                    Console.Write(" ");
                }

                for (int s = 2 * i + 1; s > 0; s--)
                {
                    Console.Write("*");
                }

                

                Console.WriteLine();
                
            }
            

        }

        
        
        
       
    }
}