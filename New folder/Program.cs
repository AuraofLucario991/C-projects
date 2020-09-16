using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Abe Ally
Hello World
ch 2.3
9/20
*/

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name");//user input prompt
            string name = Console.ReadLine();

            string myFirstVarable; //declaration statement
            myFirstVarable = "Welcome";//assignment statement

            string Var2 = "something else"; //declaration and assignment in one

            Console.WriteLine(myFirstVarable + " " + name);//print statement for console
            Console.Write("Type your first period");
            string first = Console.ReadLine();
            Console.Write("Type your second period");
            string second = Console.ReadLine();
            Console.Write("Type your third period");
            string third = Console.ReadLine();
            Console.Write("Type your fourth period");
            string fourth = Console.ReadLine();
            Console.Write("Type your fifth period");
            string fifth = Console.ReadLine();
            Console.Write("Type your sixth period");
            string sixth = Console.ReadLine();
            Console.Write("Type your seventh period");
            string seventh = Console.ReadLine();
            Console.Write("Type your eighth period");
            string eighth = Console.ReadLine();
            Console.Write("Type your ninth period");
            string ninth = Console.ReadLine();
            Console.Write("Type your tenth period");
            string tenth = Console.ReadLine();

            Console.WriteLine("is this correct?");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(sixth);
            Console.WriteLine(seventh);
            Console.WriteLine(eighth);
            Console.WriteLine(ninth);
            Console.WriteLine(tenth);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();// reading key press
        }
    }
}
