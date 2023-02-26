using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string plusMinus = "";
        Console.Write("What is your grade? ");
        int gradePerc = Convert.ToInt32(Console.ReadLine());
        int lastDigit = gradePerc % 10;
        bool pass = true;
        if (lastDigit >= 7) {
            plusMinus = "+";
        } else if (lastDigit < 3) {
            plusMinus = "-";
        }        
        if (gradePerc >= 90) {
            letter = "A";
            if (gradePerc >= 100) {
                plusMinus = "+";
            }
        } else if (gradePerc >= 80) {
            letter = "B";
        } else if (gradePerc >= 70) {
            letter = "C";
        } else if (gradePerc >= 60) {
            letter = "D";
        } else if (gradePerc < 60) {
            letter = "F";
            if (gradePerc < 53) {
                plusMinus = "-";
            }
        }
        Console.WriteLine($"Your letter grade is {letter}{plusMinus}.");
        if (gradePerc < 70) {
            pass = false;
        }
        if (pass) {
            Console.WriteLine("Congratulations! You passed!");
        } else {
            Console.WriteLine("Sorry, you didn't pass. Try harder next time.");
        }
    }
}
