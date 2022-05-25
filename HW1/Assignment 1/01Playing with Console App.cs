using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

       class PlayingwithConsole

        {
            public static void InputandOut()
            {

                Console.WriteLine("What is your Name:");
                string name = Console.ReadLine();
                Console.WriteLine("How old are you:");
                int age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine($"Hi,{name}. I can not believe your age already {age}");
                Console.WriteLine("Might I ask about your Salary?");
                uint salary = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Do you think how many employee does your compay has?");
                uint employee = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine($"So. your company has {employee} employy, and your salary is {salary}");
                Console.WriteLine("What is your astrology sign?");
                string sign = Console.ReadLine();
                Console.WriteLine("What is your favorite color?");
                string color = Console.ReadLine();
                Console.WriteLine($"Oh, your are {sign}, and you like {color}");
            }
        }
}