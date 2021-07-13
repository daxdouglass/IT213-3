using System;

namespace IT213_Douglass_Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************

            //****Assignment 3 Section 1

            //*********************************************************

            // Cycle through 10 iterations of while loop

            int i = 0;
            int sumGrade = 0;
            while (i < 10)
            {
                Console.WriteLine("Please enter a grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                
                sumGrade += grade;
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine("Counter: " + i);
                i++;

                if (i < 11)
                {
                    Console.WriteLine("You total grade is: " + sumGrade);
                    Console.WriteLine("Your average grade is: " + sumGrade / 10);
                }
            }

            
            
        }   
    }
}
