namespace PROJECT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to read roll no, name and marks of
            three subjects and calculate the total, percentage and
            division */

            //read rollno
            Console.WriteLine("Enter the Roll no.: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            //read name
            Console.WriteLine("Enter the Name of student : ");
            string name = Console.ReadLine();

            //read marks of subjects
            Console.WriteLine("Enter the marks for Science : ");
            int scienceMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for Maths : ");
            int mathsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks for english : ");
            int englishMarks = Convert.ToInt32(Console.ReadLine());


            //totalmarks calculate
            double totalmarks = (scienceMarks + mathsMarks + englishMarks);


            //check grade
            if (totalmarks >= 250) {
                string grade = "A";
                Console.WriteLine("The Grade is A");
            }
            else if (totalmarks >= 200) {
                string grade = "B";
                Console.WriteLine("The Grade is B ");

            }
            else if (totalmarks >= 150)
            {
                string grade = "C";
                Console.WriteLine("The Grade is C ");

            }
            else if (totalmarks >= 100)
            {
                string grade = "D";
                Console.WriteLine("The Grade is D");

            }
            else if (totalmarks >= 50)
            {
                string grade = "F";
                Console.WriteLine("The Grade is F ");

            }



            //print result
            Console.WriteLine("total marks = {0} \n  percentage = {1}% ",totalmarks,((totalmarks/300)*100));



            //pause key
            Console.ReadKey();
        }
    }
}
