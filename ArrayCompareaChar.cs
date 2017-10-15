using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            bool isequal = false;

            for (int i = 0 ; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i]<=arr2[i])
                {
                    isequal = true;
                    if (arr1.Length>arr2.Length)
                    {
                        isequal = false;
                    }
                    else
                    {
                        isequal = true;
                    }
                }
                else
                {
                    isequal = false;
                }
            }
            if (isequal)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));

            }
            else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));

            }

        }
    }
}
