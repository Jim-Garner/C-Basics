using System;

namespace Methods
{
    class Program
    {
        //Specify return type, in this case void as we don't need to return info. Mathod call name. And Signature.
        static void sayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }


        //Return type here is an integer.
        static int cuber ()
        {
            Console.WriteLine("Enter a number to be cubed:");
            int toBeCubed = int.Parse(Console.ReadLine());
            int cubed = toBeCubed * toBeCubed * toBeCubed;

            return cubed; //Out of the method, we want cubed to be the info used, so we return it.
        }


        static void sayHello()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name + ". You are " + age + " years old" + "!");
        }


        static void Main(string[] args)
        {
            sayHello("Jim"); //Calls the first sayHello, as this matches its signature.

            sayHello(); //Runs second sayHello, as it matches that signature.


            Console.WriteLine(cuber()); //Console writes the results of the cuber method.


        }
    }
}
