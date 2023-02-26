using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool go = true;
        int total = 0;
        float average = 0;
        int largest;
        int smallestPos = 0;
        Console.WriteLine("Enter a list of positive or negative numbers, type 0 when finished.");
        while (go) {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) {
                go = false;
            } else {
                numbers.Add(number);
            }
        }
        numbers.Sort();
        largest = numbers[numbers.Count - 1];
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
            average = total / numbers.Count;
            if (numbers[i] > 0 & numbers[i] < smallestPos) {
                smallestPos = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        if (smallestPos != 0) {
            Console.WriteLine($"The smallest positive number is: {smallestPos}");
        }
        Console.WriteLine("The sorted list is: ");
        foreach (int i in numbers) {
            Console.WriteLine(i);
        }
    }
}
