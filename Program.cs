//guys nime coment some codes ili zisi excecute as you run so if you want to run just uncomment then run ]

//number 1

//Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8

// Solution 1

/*public class Sequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 102; i++)
        {
            if (i % 2 == 0)

            Console.WriteLine( "{0}, {1}, ", i, (i + 1) * (-1));
        }
    }
}
*/

// Solution 2

/*public class Sequence
{
    static void Main (string[] args)
    {
        for (int i = 2; i < 101; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.Write("{0} ", -i);
            }
        }

        Console.WriteLine();
    }
}*/

//number 2
// Write a program that reads your age from the console and prints your age after 10 years.

// class Program
// {
//   static void tenplus()
//   {
//     Console.WriteLine("How old are you? :");
//     int Age = Convert.ToInt32(Console.ReadLine());

//     int Age10 = Age + 10;

//     Console.WriteLine("Ten years to come your age will be " + Age10);

//   }

//   static void Main(string[] args)
//   {
//     tenplus();
   
//   }
// }

// class Program  
// {  
//     static void Main(string[] args)  
//     {     
//         Console.Write("Input your current age:");  
//         int age = Convert.ToInt32(Console.ReadLine());  
//         Console.Write("Your age after 10 years:");  
//         age = age + 10;  
//         Console.Write("{0} ", age);  
//     }  
//  } 



// number 3

// Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.

public class nInterger
{
    public static void Main()
    {
        int m = 1;
        int n = 100;
 
        int[] array = new int[n - m + 1];
        for (int i = 0; i < array.Length; i++) {
            array[i] = m++;
        }
 
        Console.WriteLine(String.Join(", ", array));
    }
}

// number 4

//Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

// what the hell is fibonacci doing humu 
