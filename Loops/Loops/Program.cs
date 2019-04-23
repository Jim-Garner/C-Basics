using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic while loop; Do this while this is true;

            int index = 0;

            while (index < 100)
            {
                Console.WriteLine("Count me.");
                index++;
            }

            //Generic do while loop; Very much like a while loop; Do this, while this is true;

            int j = 0;

            do
            {
                Console.WriteLine("Love me.");
                j++;
            }

            while (j < 100);



            //Generic for loop;

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Count me again.");
            }


        }
    }
}
