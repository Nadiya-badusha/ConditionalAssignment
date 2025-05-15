using System.ComponentModel;
using System.Xml.Linq;

namespace PROJECT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to calculate and print the
            //Electricity bill of a given customer.The customer id.,
            //name and unit consumed by the user should be taken
            //from the keyboard and display the total amount to pay
            //to the customer.The charge are as follow

            //read customer id

            Console.WriteLine("enter customer ID");
            int custId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //read name
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine();

            //read unit consumed
            Console.WriteLine("enter unit consumed by user");
            int unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //check price per unit and pirnt the total amount to be payed
            if (unit >= 600)
            {

                Console.WriteLine("the total amount to pay is {0}", 2 * unit);
            }
            else if (unit < 600 && unit>400)
            {
                Console.WriteLine("the total amount to pay is {0}", 1.8 * unit);

            }else if (unit < 400 && unit>200)
            {
                Console.WriteLine("the total amount to pay is {0}", 1.5 * unit);

            }else if(unit <199)
            {
                Console.WriteLine("the total amount to pay is {0}", 1.2 * unit);

            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
