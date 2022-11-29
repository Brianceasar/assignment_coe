// Condition: Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.


namespace PrintNNumbers
{
    class Program
    {
        static void Main (string[] args)
        {
            int n;
            Console.Write("Enter the first number n: ");
            bool isInt = int.TryParse(Console.ReadLine(), out n);

            if (isInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry! n is not an integer!");
            }
        }
    }
}


