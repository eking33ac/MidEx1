using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objective: Take overall grade input from user (0 to 100)

            double gradeInput = Double.MaxValue;
            double roundGrade = Double.MaxValue;
            string cutGrade = String.Empty;

            while (gradeInput == Double.MaxValue) {
                Console.Write("Input your grade: ");
                gradeInput = Convert.ToDouble( Console.ReadLine());

                if (gradeInput < 0 || gradeInput > 100)
                {
                    Console.WriteLine("Input out of range. Ensure number is between 0 and 100.");
                    gradeInput = Double.MaxValue;
                }
            }


            // round grade input to nearest 10ths place
            roundGrade = Math.Round(gradeInput);

            Console.WriteLine(roundGrade);

            // Convert to a letter grade using a switch statement

            int div10 = Convert.ToInt32( roundGrade / 10);

            Console.WriteLine(div10);

            switch (div10)
            {
                case 10:
                case 9:
                    Console.WriteLine($"{gradeInput} is an A");
                    break;
                case 8:
                    Console.WriteLine($"{gradeInput} is an B");
                    break;
                case 7:
                    Console.WriteLine($"{gradeInput} is an C");
                    break;
                case 6:
                    Console.WriteLine($"{gradeInput} is an D");
                    break;
                default:
                    Console.WriteLine($"{gradeInput} is an F");
                    break;
            }

            Console.ReadLine();
        }
    }
}
