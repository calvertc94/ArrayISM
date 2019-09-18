using System;

namespace ISM4300Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] NumericalArray = new int[25];

                for (int i = 0; i < 25; i++)
                {
                    NumericalArray[i] = i;
                    Console.WriteLine("Element value = " + (i + 1));

                }
            }

            catch
            {
                Console.WriteLine("There was an error with this program, please run it again");
            }
        }
    }
}
