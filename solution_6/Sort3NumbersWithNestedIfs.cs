// Condition: Using nested if-statement Write a program that sorts 3 real numbers in descending order

namespace Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {                        
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            Console.ReadLine();
        }
    }
}

















// namespace Sort3NumbersWithNestedIfs
// {
//     class Sort3NumbersWithNetsedIfs
//     {
//         static void Main()
//         {
//             double a = double.Parse(Console.ReadLine());
//             double b = double.Parse(Console.ReadLine());
//             double c = double.Parse(Console.ReadLine());
  
//             if ((a > b) && (a > c))
//             {
//                 if (b > c)
//                 {
//                     Console.WriteLine("{0} {1} {2}", a, b, c);
//                 }
//                 else
//                 {
//                     Console.WriteLine("{0} {1} {2}", a, c, b);
//                 }
//             }
//             else if ((b > a) && (b > c))
//             {
//                 if (a > c)
//                 {
//                     Console.WriteLine("{0} {1} {2}", b, a, c);
//                 }
//                 else
//                 {
//                     Console.WriteLine("{0} {1} {2}", b, c, a);
//                 }
//             }
//             else if ((c > a) && (c > b))
//             {
//                 if (a > b)
//                 {
//                     Console.WriteLine("{0} {1} {2}", c, a, b);
//                 }
//                 else
//                 {
//                     Console.WriteLine("{0} {1} {2}", c, b, a);
//                 }
//             }
//         }
//     }
// }