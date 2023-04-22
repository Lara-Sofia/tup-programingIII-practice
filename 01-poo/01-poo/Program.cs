using System;
using System.Xml.Linq;

namespace _01_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "----------";
            //Create an object of MyClass called myObj.
            MyClass myObj = new MyClass();

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


            //-----ARRAY------
            //Create an array of type string called cars.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(line);

            //Change the value from "Volvo" to "Opel", in the cars array.
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(line);

            //Use the correct method to sort the cars array.
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(line);

            //Method
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
            Console.WriteLine(line);
            
            Console.WriteLine(MyMethod(3));
            Console.WriteLine(line);
        }

        //Add a fname parameter of type string to MyMethod.
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        

        //missing part to print the number 8 in Main, by using a specific keyword inside MyMethod:
        static int MyMethod(int x)
        {
           return  5 + x;
        }
    }
}
