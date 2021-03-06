using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Practicearrays
    {
        public static void Copyinganarray()
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
                Console.Write(firstArray[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i]);
            }
        }

        public static void Changelistelement()
        {
            List<string> listlist = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                switch (input.Substring(0, 2))
                {
                    case "+ ":
                        listlist.Add(input.Substring(2, input.Length - 2));
                        foreach (string s in listlist) Console.Write($"{s} ");
                        Console.WriteLine();
                        break;
                    case "- ":
                        listlist.Remove(input.Substring(2, input.Length - 2));
                        foreach (string s in listlist) Console.Write($"{s} ");
                        Console.WriteLine();
                        break;
                    case "--":
                        listlist.Clear();
                        foreach (string s in listlist) Console.Write($"{s} ");
                        Console.WriteLine();
                        break;
                }

            }
        }

        public static void FindPrimesInRange(int start, int end)
        {
            int i = 14;
            int[] ay = { 1, 2, 3, 5, 7, 9, 11, 13 };
            List<int> listPrimes = new List<int>(ay);
            if (end > 13)
            {
                for (; i <= end; i++)
                {
                    int nfactor = 0;
                    foreach (int s in listPrimes)
                    {
                        if (i % s == 0) nfactor++;
                        if (nfactor >= 2) break;
                    }
                    if (nfactor == 1) listPrimes.Add(i);
                }
            }
            else
            {
                i = 7;
                while(listPrimes[i]> end)
                {
                    listPrimes.RemoveAt(i);
                    i--;
                }
            }
            i = 0;
            while (listPrimes[i] <= start) i++;
            int [] answer = new int[listPrimes.Count-i];
            for (int j = 0; i + j < listPrimes.Count; j++)
            {
                answer[j] = listPrimes[j + i];
                Console.Write($"{answer[j]} ");
            }

        }
        public static void Rotate()
        {
            int i = 0;
            int sum;
            Console.WriteLine("Please enter your array of intergers(space separated on a single Line and don't add space in the end)");
            string input = Console.ReadLine();
            int[] arrays = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine("Please enter the rotate time you want");
            int rotateTime = Convert.ToInt32(Console.ReadLine());
            int [] answer = new int [arrays.Length];
            for(i = 0; i < arrays.Length; i++)
            {
                sum = 0;
                for(int j = 1; j <= rotateTime % arrays.Length; j++)
                {
                    sum = sum + arrays[(i + arrays.Length - j) % arrays.Length];
                }
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }

        public static void Longestsequence()
        {
            Console.WriteLine("Please enter your array of intergers(space separated on a single Line and don't add space in the end)");
            string input = Console.ReadLine();
            int[] arrays = Array.ConvertAll(input.Split(' '), int.Parse);
            int i = 0;
            int j = 0;
            int max = 0;
            int[] indexs = new int[2];
            while(j < arrays.Length)
            {
                if (j + 1 < arrays.Length && arrays[j] != arrays[j + 1])
                {
                    if (i != j)
                    {
                        if (j - i + 1 > max)
                        {
                            max = j - i + 1;
                            indexs[0] = i;
                            indexs[1] = j;
                        }
                    }
                    j++;
                    i = j;
                }
                else j++;
            }
            if(i != j && j - i + 1 > max)
            {
                indexs[0] = i;
                indexs[1] = j - 1;
            }
            for(i = indexs[0]; i <= indexs[1]; i++) Console.WriteLine(arrays[i]);
        }

        public static void Mostfrequent()
        {
            Console.WriteLine("Please enter your array of intergers(space separated on a single Line and don't add space in the end)");
            string input = Console.ReadLine();
            int[] arrays = Array.ConvertAll(input.Split(' '), int.Parse);
            Dictionary<int, int> mfrequent = new Dictionary<int, int>();
            for(int i = 0; i < arrays.Length; i++)
            {
                if (mfrequent.ContainsKey(arrays[i])) mfrequent[arrays[i]]++;
                else mfrequent.Add(arrays[i], 1);
            }
            int key = -1;
            int max = 0;
            foreach (int i in mfrequent.Keys)
            {

                if(mfrequent[i] > max)
                {
                    max = mfrequent[i];
                    key = i;
                }
            }
            Console.WriteLine(key);
        }

    }
}
