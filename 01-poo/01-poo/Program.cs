using System;

namespace _01_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "----------";

            //to convert the int variable to a string
            int myInt = 10;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(line);

            //to get user input
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            Console.WriteLine(line);

            //to print a number put in by the user:
            Console.WriteLine("Think of a number:");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNum);
            Console.WriteLine(line);

            //to print the highest value of x and y.
            int x = 5;
            int y = 10;
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(line);

            //to print the square root of x.
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(line);

            //to round the number 2.6 to its nearest integer.
            Console.WriteLine(Math.Round(2.6));
            Console.WriteLine(line);

            //to print the length of the txt string.
            string txt = "Hello";
            Console.WriteLine(txt.Length);
            Console.WriteLine(line);

            //to output the value of the txt string to upper case letters.
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(line);

            //Fill in the missing parts to print the value True:
            int xx = 10;
            int yy = 9;
            Console.WriteLine(xx > yy);
            Console.WriteLine(line);

            //ternary operator:
            int time = 20;
            string result = (time < 18)?  "Good day." : "Good evening.";
            Console.WriteLine(result);
            Console.WriteLine(line);


        }
    }
}
