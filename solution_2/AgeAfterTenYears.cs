// Condition: Write a program that reads your age from the console and prints your age after 10 years.

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: " + (age + 10));
        }
    }
}