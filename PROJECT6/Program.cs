using System.ComponentModel;
using System;

namespace PROJECT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Write a program in C# which is a Menu-Driven Program
        //to perform a simple calculation


            #region switch
            //mathamatical operations
            int firstNumber = 0, secondNumber = 0;
            char continuechoice = 'n';

            do
            {

                //get input from user
                Console.WriteLine("enter first value");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter second value");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //show the actions
                Console.WriteLine("1.addition");
                Console.WriteLine("2.difference");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.Division");

                //get choice
                Console.Write("enter your choice(1-4):");
                int choice = Convert.ToInt32(Console.ReadLine());



                //process output
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("sum is:" + (firstNumber + secondNumber));
                        break;

                    case 2:
                        Console.WriteLine("the difference: " + (secondNumber - firstNumber));
                        break;
                    case 3:
                        Console.WriteLine("the product is :" + (firstNumber * secondNumber));
                        break;
                    case 4:
                        Console.WriteLine("the quotient is: " + (secondNumber / firstNumber));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;



                }
                //ask if we want to continue
                Console.Write("do you want to contimue? \n (y to continue,n to exit)");
                continuechoice = Convert.ToChar(Console.ReadLine().ToLower());
            }
            while (continuechoice == 'y');


            #endregion


            //pause the key
            Console.ReadKey();
        }
    }
}
