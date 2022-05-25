using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Practicestrings
    {
        public static void Reversesstring()
        {
            Console.WriteLine("Please entry your string");
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());
            int i = 0;
            int j = input.Length - 1;
            char c;
            while ( i <  j)
            {
                c = input[i];
                input[i] = input[j];
                input[j] = c;
                i++;
                j--;
            }
            Console.WriteLine(input);
        }

        public static void Reversessentence()
        {
            Console.WriteLine("Please entry your string");
            string input = Console.ReadLine();
            int i = 0;
            int j = i;
            int n = input.Length - 1;
            int m = n;
            string head = "";
            string tail = "";
            while (j < m)
            {
                while (input[j] != '.' && input[j] != ',' && input[j] != ':' && input[j] != ';' && input[j] != '=' && input[j] != '(' &&
                    input[j] != ')' && input[j] != '&' && input[j] != '[' && input[j] != ']' && input[j] != '"' && input[j] != '\'' && input[j] != '/' &&
                    input[j] != '!' && input[j] != '?' && input[j] != ' ' && input[j] != '\\') j++;
                while (input[m] != '.' && input[m] != ',' && input[m] != ':' && input[m] != ';' && input[m] != '=' && input[m] != '(' &&
                    input[m] != ')' && input[m] != '&' && input[m] != '[' && input[m] != ']' && input[m] != '"' && input[m] != '\'' && input[m] != '/' &&
                    input[m] != '!' && input[m] != '?' && input[m] != ' ' && input[m] != '\\') m--;
                if (j < m)
                {
                    if (m == n && i == j)
                    {
                        tail = input[m] + tail;
                        head = head + input[j];
                        j++;
                        i = j;
                        m--;
                        n = m;
                    }
                    else if (m == n && i != j)
                    {
                        tail = input[m] + tail;
                        m--;
                        n = m;

                    }
                    else if (m != n && i == j)
                    {
                        head = head  + input[j];
                        j++;
                        i = j;
                    }
                    else
                    {
                        tail = input[m] + input.Substring(i, j-i)  + tail;
                        head = head + input.Substring(m+1, n-m) + input[j];
                        j++;
                        i = j;
                        m--;
                        n = m;
                    }
                }
                else
                {
                    Console.WriteLine(head + input.Substring(m + 1, n-m) + tail);
                    break;
                }
            }

        }
        public static void Palindromes()
        {
            Console.WriteLine("Please enter your String");
            string input = Console.ReadLine();
            int n = 0;
            int st = 0;
            List<string> answer = new List<string> ();
            for (int i = 0; i <input.Length; i++)
            {
                if(char.IsLetter(input[i]) == false && i !=0 )
                {
                    int x = n;
                    int y = i - 1;
                    int check = 0;
                    while(x < y)
                    {
                        if(input[x] != input[y])
                        {
                            check = 1;
                            break;
                        }
                        x++;
                        y--;
                    }

                    if (check == 0)
                    {
                    Console.Write($"{input.Substring(n, i - n)}, ");
                    }
                    n = i + 1;
                }
            }
            Console.WriteLine();
        }

        public static void ParsesURL()
        {
            Console.WriteLine("Please enter your URL:");
            string input = Console.ReadLine();
            int part = 0;
            int n = 0;
            int i = 0;
            while(i < input.Length)
            {
                if (input[i] == ':' && input[i + 1] == '/' && input[i + 2] == '/')
                {
                    Console.WriteLine($"[protocol] = \" {input.Substring(n, i)}\"");
                    part = 1;
                    i = i + 3;
                    n = i;
                }
                else if ((input[i] == '/' && input[i-1]!='/'))
                {
                    part = 2;
                    if (part == 0)
                    {
                        Console.WriteLine($"[protocol] = \"\"");
                        Console.WriteLine($"[server] = \"{input.Substring(n, i)}\"");
                        Console.WriteLine($"[resource] = \"{input.Substring(i+1,input.Length - i -1)}\"");
                    }
                    else
                    {
                        Console.WriteLine($"[server] = \"{input.Substring(n, i-n)}\"");
                        Console.WriteLine($"[resource] = \"{input.Substring(i + 1, input.Length - i -1)}\"");
                    }

                }
                i++;
            }
            if (part == 0)
            {
                Console.WriteLine($"[protocol] = \"\"");
                Console.WriteLine($"[server] = \"{input}\"");
                Console.WriteLine($"[resourcel] = \"\"");
            }
            else if (part == 1)
            {
                Console.WriteLine($"[server] = \"{input.Substring(n, i - n)}\"");
                Console.WriteLine($"[resourcel] = \"\"");
            }

        }
    }
}
