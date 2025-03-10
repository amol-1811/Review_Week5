using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Review_Week5
{
    internal class TPLOperations
    {
        public static async Task TPL()
        {
            Console.WriteLine("Running operations ");

            int[] array = { 5, 9, 7, 8, 6, 3 };

            Task<List<string>> task1 = TPLOperations.SortList();
            Task<int> task2 = TPLOperations.SumOfArray(array);
            Task task3 = TPLOperations.WriteNumbersToFile();

            await Task.WhenAll(task1, task2, task3);

            List<string> sortedstring = await SortList();
            foreach (string str in sortedstring)
            {
                Console.WriteLine(str);
            }

            int sum = await SumOfArray(array);
            Console.WriteLine(sum);

            Console.WriteLine("operation completed ");
        }

        public static async Task WriteNumbersToFile()
        {
            string path = @"C:\Users\amol-gosavi\source\repos\amol-1811\Review_Week5\Review_Week5\numbers.txt";
            //File.Create(path);

            using (StreamWriter file = new StreamWriter(path))
            {
                for (int i = 1; i <= 10; i++)
                {
                    file.WriteLine(i);
                }
            }
            Console.WriteLine("Numbers written to file.");
        }

        public static async Task<int> SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static async Task<List<string>> SortList()
        {
            List<string> list = new List<string> { "Amol", "Rishi", "Asmita", "Puja", "Disha" };

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    int strLength = CompareStrings(list[j], list[j + 1]);
                    if (strLength > 0)
                    {
                        string temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public static int CompareStrings(string str1, string str2)
        {
            return string.Compare(str1, str2);
        }
    }
}
