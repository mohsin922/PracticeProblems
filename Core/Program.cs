using System;
using System.Text;
namespace Core
{
    public class Core
    {
        public static void Main(string[] args)
        {
            ////Fibonacci Series
            //int number1 = 0, number2 = 1, number3, i, number;
            //Console.Write("Enter the number of elements: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.Write(number1 + " " + number2 + " ");
            //for (i = 2; i <= number; i++)
            //{
            //    number3 = number1 + number2;
            //    Console.Write(number3 + " ");
            //    number1 = number2;
            //    number2 = number3;
            //}


            ////Reverse a number
            //Console.WriteLine("Enter a No. to reverse");
            //int i;
            //int Number = int.Parse(Console.ReadLine());
            //int Reverse = 0;
            //for (i = Number; i > 0; i = i / 10)
            //{
            //    int remainder = i % 10;
            //    Reverse = (Reverse * 10) + remainder;


            //}
            //Console.WriteLine("Reverse No. is {0}", Reverse);






            //// //string Palindrome 
            //string a = string.Empty;
            //Console.WriteLine("Enter  a String");
            //a = Console.ReadLine();
            ////Convert input string to char array 
            //char[] stringArray = a.ToCharArray();

            //string reverse = string.Empty;
            //// Reverse using for loop
            //for (int i = stringArray.Length - 1; i >= 0; i--)
            //{
            //    reverse += stringArray[i];
            //}
            //if (a.Equals(reverse))
            //{
            //    Console.WriteLine("palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}



            ////Number Palindrome
            //Console.WriteLine("Enter a No.");
            //int Number = int.Parse(Console.ReadLine());
            //int temp = Number;
            //int Reverse = 0;
            //while (Number > 0)
            //{
            //    int remainder = Number % 10;
            //    Reverse = (Reverse * 10) + remainder;
            //    Number = Number / 10;
            //}
            //if (temp == Reverse)
            //{
            //    Console.Write("Number is Palindrome.");
            //}
            //else
            //{ 

            //    Console.Write("Number is not Palindrome");
            //}



            //Highest Number in Array
            Console.WriteLine("Enter length of Array To find Hghest Number");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Enter Number { i } Position: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < Length; j++)
            {
                
                Console.WriteLine("Numbers in Array are: "+Array[j]);
            }
            int max = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    max = Array[i];
                }
                else
                {
                    max = Array[i + 1];
                }
                
            }
            Console.WriteLine("\nMax Value in Array: " + max);


        }
    }
}
