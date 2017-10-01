using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool prepare = true;
            while (prepare)
            {
               
                string input = Console.ReadLine();
                if (input != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                    count++;
                }
                

                if (input =="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    prepare = false;
                    break;
                }
            }
        }
    }
}
