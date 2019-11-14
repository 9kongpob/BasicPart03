using System;

namespace BasicPart03_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            string grade;

            Console.Write("Input your score: ");
            int.TryParse(Console.ReadLine(), out score);

                if (score >= 80 && score <= 100)
                {
                    grade = "A";
                }
                else if (score >= 75 && score <= 79)
                {
                    grade = "B+";
                }
                else if (score >= 70 && score <= 74)
                {
                    grade = "B";
                }
                else if (score >= 65 && score <= 69)
                {
                    grade = "C+";
                }
                else if (score >= 60 && score <= 64)
                {
                    grade = "C";
                }
                else if (score >= 55 && score <= 59)
                {
                    grade = "D+";
                }
                else if (score >= 50 && score <= 54)
                {
                    grade = "D";
                }
                else if (score >= 0 && score <= 49)
                {
                grade = "F";
                }
                else
                { 
                    grade = "Score Wrong!";
                }

            Console.WriteLine("Your Grade : " + grade);
            Console.ReadKey();

        }
    }
}
