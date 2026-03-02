using System;

namespace NewConsoleApp

{
    
    class Program 
    {
        static void Main() 
        {
            while (true)
            {
                Calculator myCalculator = new Calculator();
                myCalculator.Calculate();
                bool again = myCalculator.Again();

                if(again)
                {
                    myCalculator.Calculate();
                }
                else
                {
                    break;
                }
            }
        }
    }

    interface ICalculator
    {
        void Calculate();
        bool Again();
    }

    class Calculator : ICalculator
    {
        public bool Again()
        {
            bool again;
            Console.WriteLine("Another Calculation? y/n");
            string myString = Console.ReadLine();
            if (myString == "y")
            {
                again = true;
            }
            else
            {
                again = false;
            }

            return again;
        }
        
        public void Calculate()
        {
            string operation;
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Operation Type: ");
            operation = Console.ReadLine();
            
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (operation == "/")
            {
                if (num1 != 0 && num2 != 0)
                {
                    Console.WriteLine(num1 / num2);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation.");
            }
            
        }
    }
}