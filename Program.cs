using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: "); //Prompting the user to enter their first value
            double num1 = Convert.ToDouble(Console.ReadLine()); //Storing the first value they entered into a variable called 'num1'. 
            // Also Console.ReadLine() returns a string so if we want to store a double we must convert it to be a double, Console.ReadLine() is passed in as a parameter/argument into 
            // the Convert.ToDouble method.


            Console.Write("Enter a operator: "); //Prompting the user to enter an operator (+, -, /, *)
            string op = Console.ReadLine(); //Storing the operator the user entered and saving it as a variable called 'op'


            Console.Write("Enter a number: "); //Prompting the user to enter their second value
            double num2 = Convert.ToDouble(Console.ReadLine()); //Storing the second value they entered into a variable called 'num2'


            if (op == "+")  //Checking whether the operator is equal to a + 
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "=") //Checking whether the operator is equal to a - 
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/") //Checking whether the operator is equal to a / 
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*") //Checking whether the operator is equal to a * 
            {
                Console.WriteLine(num1 * num2);
            } else //Error message to display if the user enters an invalid operator
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}
