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

            int c = 0;
            double sumGrade = 0;
            while (c < 10)                                            
            {
                Console.Write("Please enter a grade: ");
                int gradeInput = Convert.ToInt32(Console.ReadLine());
                
                sumGrade += gradeInput;                                  // Sum the grades entered
                c++;                                                // Increment the iteration counter                  

                    if (c == 10)                                     // Print overall total and class average grade after last grade entered
                {
                    double avgGrade = sumGrade / 10;
                    Console.WriteLine($"\nOverall total grade is: {sumGrade}");
                    Console.WriteLine($"\nClass average grade is: {avgGrade:F}");                    
                }
            } 

            //*********************************************************

            //****Assignment 3 Section 2

            //*********************************************************

            int k, i;
           
            for (k = 5; k >= 1; k--)                                         // Start outer loop at 5 and decrement by 1 until 1
            {
                for (i = 0; i <= 10; i += 2)                                 // Start inner loop at 0 and increment by 2 until 10
                {
                    Console.WriteLine("k = " + k + ", i = " + i );
                    
                }                
            }

            //*********************************************************

            //****Assignment 3 Section 3

            //*********************************************************

            int total = 0;
            int count = 0;

            Console.Write("Enter grade or -1 to quit: ");
            int grade = int.Parse(Console.ReadLine());

            while (grade != -1)                                             // Execute loop if user said not to quit
            {
                total += grade;                                             // Add grade to running total
                count++;

                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
            }

            if (count != 0)                                                  // Check if any grades were entered
            {
                double average = (double)total / count;                      // Calculated the average of the grades
                Console.WriteLine($"\nTotal of the {count} grades entered is {total}");
                Console.WriteLine($"The class average is {average:F}");
            }
            else                                                             // No grades were entered
            {
                Console.WriteLine("No grades were entered");
            }

        }
    }
}
