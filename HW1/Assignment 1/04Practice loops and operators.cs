using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public static class Practiceoloopandoperators
    {
        public static void FizzBuzzis()
        {
            for (int i = 1; i < 100; ++i)
            {
                if (i % 15 == 0) Console.WriteLine("fizzbuzz");
                else if (i % 5 == 0) Console.WriteLine("buzz");
                else if (i % 3 == 0) Console.WriteLine("fizz");
                else Console.WriteLine(i);
            }
        }

        public static void infinityloop()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if (i.GetType() != max.GetType())  throw (new ApplicationException("The type of variable of initial value in for loop and the type of variable of Max is not the same type "));
                Console.WriteLine(i);
            }
        }

        public static void Guessgame()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please Enter you guess:");
            int guessNumber;
            guessNumber =Convert.ToInt32( Console.ReadLine());
            if (guessNumber == correctNumber) Console.WriteLine("It's correct answer");
            else if (guessNumber < correctNumber && guessNumber >= 1) Console.WriteLine("It too low");
            else if (guessNumber > correctNumber && guessNumber <= 3) Console.WriteLine("It too high");
            else Console.WriteLine("your guess out range");
        }

        public static void star(int level)
        {
            for (int i = 1; i <= level; ++i)
            {
                for(int j = level-i; j >= 0; --j) Console.Write(" ");
                for (int k = (i-1)*2; k >0; --k) Console.Write("*");
                Console.WriteLine("*");
            }
        }

        public static void  Calculatesday()
        {
            Console.WriteLine("Enter your birthday:");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            double days = (DateTime.Today - birthday).TotalDays;
            Console.WriteLine(days);
            Console.WriteLine($"Days to next Anniversary is {10000 - (days % 10000)}");
        }

        public static void Appropriategreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour <12 && hour > 8) Console.WriteLine("Good Morning");
            if (hour < 18 && hour >= 12) Console.WriteLine("Good Afternoon");
            if (hour < 20 && hour >= 18) Console.WriteLine("Good Evening");
            if ((hour <= 24 && hour >=20) || hour <= 8) Console.WriteLine("Good Night");
            Console.WriteLine(hour);
        }

        public static void Fourloop()
        {
            for(int i = 1; i < 5; i++)
            {
                for(int j = 0; j < 24; j = j + i )
                {
                    Console.Write($"{j},");
                }
                Console.WriteLine(24);
            }
        }

    }

}
