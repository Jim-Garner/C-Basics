using System;

namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare array, but put comma in square brackets. Telling computer that this array has more than one dimension.

            int[,] numberGrid =
            {
                //Enter arrays with main array
                {1,2,},
                {3,4},
                {5,6}
            };


            //To access array, choose row number, then column number. Below would print six.
            Console.WriteLine(numberGrid[2,1]);

        }
    }
}
