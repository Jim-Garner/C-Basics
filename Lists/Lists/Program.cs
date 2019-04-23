using System;
using System.Collections.Generic; //This is needed to use Generics. Listing is part of Generics

namespace Lists
{
    class Program
    {
        //Lists are perfect for dynamic data sets. Fixed data sets should use arrays;


        static void Main(string[] args)
        {
            List<int> grades3 = new List<int>();
            grades3.Add(5);
            grades3.Add(1);
            grades3.Add(2);



            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Dawn");

            for(int i = 0; i <= names.Count; i++)
            {
                Console.WriteLine(grades3[i]);
            }



        }
    }
}
