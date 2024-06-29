using System;

namespace CalcGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';

            Console.WriteLine("Your grade is " + grade);
        }
    }
}
