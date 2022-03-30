using System;
using System.Collections;

namespace Collection_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(1980,"C++");
            sortedList.Add(1970, "Pacsal");
            sortedList.Add(1995, "PHP");
            sortedList.Add(1966, "JOSS");
            sortedList.Add(1978, "SQL");

            foreach (DictionaryEntry item in sortedList)
            {

                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
