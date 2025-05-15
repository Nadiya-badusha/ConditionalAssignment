namespace PROJECT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Write a C# program to read the age of a candidate and
            determine whether it is eligible for casting his/her own
            vote */

            //input from user
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());


            //check if eligible to vote or not
            if (age < 18)
            {
                Console.WriteLine("The candidate is not eligible to vote. the candidate's age is less than 18 ");
            }
            else if(age>150)
            {
                Console.WriteLine("Invalid age , the age should not be more than 150 ");

            }   
            else
            {
                Console.WriteLine("The candidate is eligible to vote ");
            }

            //pause key
            Console.ReadKey();
        }


    }
}
