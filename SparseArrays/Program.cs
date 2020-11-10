using System;
using System.Collections.Generic;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);
            Console.WriteLine(string.Join(" ", res));
            Console.ReadLine();
        }
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (keyValuePairs.ContainsKey(strings[i]))
                {
                    keyValuePairs[strings[i]]++ ;
                }
                else
                {
                    keyValuePairs[strings[i]] = 1;
                }
            }
            for (int j = 0; j < queries.Length; j++)
            {
                if (keyValuePairs.ContainsKey(queries[j]))
                {
                    result[j] = keyValuePairs[queries[j]];
                }
            }
            return result;
        }
    }
}
