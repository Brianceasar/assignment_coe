//guys nime coment some codes ili zisi excecute as you run so if you want to run just uncomment then run ]

//number 1

//Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8

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
