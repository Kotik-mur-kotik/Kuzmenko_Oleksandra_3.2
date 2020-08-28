using System;
using System.Collections;
using System.Collections.Generic;

namespace laba3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int> { { 1, 10 }, { 2, 100 }, { 3, 25 }, { 4, 25 }, { 5, 125 } };
            ArrayList list = new ArrayList();
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (var key in dictionary.Keys)
            {
                max = (max < dictionary[key]) ? dictionary[key] : max;
                min = (min > dictionary[key]) ? dictionary[key] : min;
            }
            list.Add(max);
            list.Add(min);
            Console.WriteLine($"{list[0]}  {list[1]}");
        }
    }
}
