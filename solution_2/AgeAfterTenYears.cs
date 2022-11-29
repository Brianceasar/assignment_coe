// Condition: Write a program that reads your age from the console and prints your age after 10 years.

namespace AgeAfterTenYears 
{
    class AgeAfterTen
    {
        static void Main (string[] args)
        {
            Console.Write("Input your current age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your age after 10 years: ");

            age = age + 10 ;

            Console.Write("{0} ", age);
        }
    }
}
