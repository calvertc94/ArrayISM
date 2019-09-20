using System;

namespace ISM4300Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Initializes an array with 25 indexes
                int[] NumericalArray = new int[25];

                //Loops through the code 25 times
                for (int i = 0; i < 25; i++)
                {
                    //Sets the index value of the array to the current number of times the loop has run
                    NumericalArray[i] = i;
                    //Prints 1-25 without printing the first number as 0
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
