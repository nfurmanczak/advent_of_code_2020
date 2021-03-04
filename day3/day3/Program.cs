using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> map = ImportFile();

            var input = System.IO.File.ReadAllLines(@"@../../../../../../input2.txt").ToArray();
            var output = 1;
            List<KeyValuePair<int, int>> slopes = new List<KeyValuePair<int, int>>()
        {
            new KeyValuePair<int, int>(1,1),
            new KeyValuePair<int, int>(3,1),
            new KeyValuePair<int, int>(5,1),
            new KeyValuePair<int, int>(7,1),
            new KeyValuePair<int, int>(1,2)
        };

            foreach (var slope in slopes)
            {
                var trees = 0;
                var right = slope.Key;
                for (int x = slope.Value; x < input.Length; x += slope.Value)
                {
                    if (input[x][right] == '#')
                    {
                        trees++;
                    }

                    right += slope.Key;

                    if (right >= input[x].Length)
                    {
                        right = right - input[x].Length;
                    }
                }

                output = output * trees;
                Console.WriteLine(trees);
            }
            
        }

        public static List<string> ImportFile()
        {
            List<string> input = new List<string>(); 
            using (var sr = new StreamReader(@"@../../../../../../input2.txt", true))
            {
                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine()); 
                }
            }

            return input; 
        }
    }
}
/* 
 * 
 * 
 * 
 * Right 1, down 1 - Trees: 53
Right 3, down 1 - Trees: 167
Right 5, down 1 - Trees: 54
Right 7, down 1 - Trees: 67
Right 1, down 2 - Trees: 23
Product: 736527114
 * 
 * 
 */