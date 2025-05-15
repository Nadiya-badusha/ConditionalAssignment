using System.Buffers.Text;
using System.ComponentModel;

namespace PROJECT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        Write a C# program to find the eligibility of admission for
                        a professional course based on the following criteria:
                        Marks in Maths >= 65
                        Marks in Phy >= 55
                        Marks in Chem >= 50
                        Total in all three subject >= 180
                        or
                        Total in Math and Subjects >= 140*/

            //read marks of subjects
            Console.WriteLine("Enter the marks for Maths : ");
            int mathsMarks = Convert.ToInt32(Console.ReadLine());

            if (mathsMarks >= 65)
            {
                Console.WriteLine("maths marks is suffient");

                Console.WriteLine("Enter the marks for Physics : ");
                int phyMarks = Convert.ToInt32(Console.ReadLine());

                if (phyMarks >= 55)
                {
                    Console.WriteLine("Physics marks is suffient");


                    Console.WriteLine("Enter the marks for chemistry : ");
                    int chemMarks = Convert.ToInt32(Console.ReadLine());

                    if (chemMarks >= 50)
                    {
                        Console.WriteLine("chemistry marks is suffient");
                        if ((mathsMarks + phyMarks + chemMarks) >= 180)
                        {
                            Console.WriteLine("total marks is suffient,the student is eligible ");

                            //pause key
                            Console.ReadKey();
                        }
                        else if ((mathsMarks + phyMarks) >= 140)
                        {
                            Console.WriteLine("the student is eligible");
                        }
                        else if ((mathsMarks + chemMarks) >= 140)
                        {
                            Console.WriteLine("the student is eligible");
                        }
                        else
                        {
                            Console.WriteLine("the student is not eligible");
                        }
                    }
                    else
                    {
                        Console.WriteLine("the student is not eligible");
                    }
                }
                else
                {
                    Console.WriteLine("the student is not eligible");

                    //pause key
                    Console.ReadKey();

                }

            }
            else
            {
                Console.WriteLine("the student is not eligible");

                //pause key
                Console.ReadKey();

            }

        }
           






        }
    }

