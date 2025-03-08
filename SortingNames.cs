using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Week5
{
    internal class SortingNames
    {
        public static void SortNames()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter names. Enter 'done' to stop.");
            string name = Console.ReadLine();
            while (name != "done")
            {
                names.Add(name);
                name = Console.ReadLine();
            }
            Sort(names);
            Console.WriteLine("Sorted names:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }

        public static void Sort(List<string> names)
        {
            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int j = i + 1; j < names.Count; j++)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }
        }
    }
}
