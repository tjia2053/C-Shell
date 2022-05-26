using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Working_with_methods
    {
        public static int[] GenerateNumber(int end)
        {
            int [] numberArray = new int[end];
            for (int i = 0; i <end; i++)
            {
                numberArray[i] = i + 1;
            }
            return numberArray;
        }

        public static void Reverse(int [] input)
        {
            
            int i = 0;
            int j = input.Length - 1;
            while(i < j)
            {
                int temp;
                temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                i++;
                j--;
            }
        }

        public static void PrintNumbers(int [] input)
        {
            foreach (int i in input)
                Console.WriteLine(i);
        }

        public static int Fibonacci(int input)
        {
            if (input == 1 || input == 2) return 1;
            else return Fibonacci(input - 1) + Fibonacci(input - 2);

        }
    }
}
