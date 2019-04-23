using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is now a physical book inside the program thanks to Book.cs;

            //Object; Object name; New object; We're saying "Here is a new book. Here's its title, author and page quantity";
            Book book1 = new Book();
            book1.title = "Lord of the Rings";
            book1.author = "J.R.R.Tolkien";
            book1.pages = 845;

            Book book2 = new Book();
            book2.title = "Harry Potter";
            book2.author = "J.K.Rowling";
            book2.pages = 400;

            //Student Class

            Student student1 = new Student();
            student1.name = "Michael Jones";
            student1.age = 21;
            student1.gender = "Male";



            Console.WriteLine(student1.name);
            Console.WriteLine(student1.age);
            Console.WriteLine(student1.gender);


        }
    }
}
