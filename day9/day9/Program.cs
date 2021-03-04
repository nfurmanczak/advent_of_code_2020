using System;
using System.Collections.Generic;
using System.IO;


namespace day9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = LoadInputFromFile();
            List<long> preamble = new List<long>();
            List<long> preambleAdd = new List<long>(); 

            int counter = 0; 


            for (int i = 0; i < input.Count; i++)
            {
                if (counter < 25)
                {
                    preamble.Add(input[i]);
                }
                counter++;

                foreach (var z1 in preamble)
                {
                    foreach (var z2 in preamble)
                    {
                        if (z1 == z2)
                            continue;


                    }
                }


            }


            counter = 1; 
            foreach (var item in preamble)
            {
                Console.WriteLine(counter + " : " +item);
                counter++; 
            }

        }

        static public List<long> LoadInputFromFile()
        {
            List<long> i = new List<long>();
           
            var sr = new StreamReader(@"@../../../../../../input.txt", true);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                i.Add(Convert.ToInt64(line));
            }

            return i;
        }

    }
}
