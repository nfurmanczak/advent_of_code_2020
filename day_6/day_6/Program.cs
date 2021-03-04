using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1
            List<Answers> b1 = Importfile();

            int sum = 0;

            foreach (var item in b1)
            {
                sum += item.CountAnswers();          
            }

            Console.WriteLine("Part 1: " + sum);

            // PART 2 
            Part2(); 

        }


        public static List<Answers> Importfile()
        {

            List<Answers> a1 = new List<Answers>();
            Answers x1 = new Answers();
            

            var sr = new StreamReader(@"@../../../../../../input.txt", true);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
 
                if (!String.IsNullOrEmpty(line))
                {
                    foreach (var item in line)
                    {
                        string s = Convert.ToString(item);
                        if (!x1.userAnswers.Contains(s))
                            x1.userAnswers.Add(s);    
                    }
                }
                else
                {
                    // Zeile ist leer, neues Object
                    a1.Add(x1);
                    x1 = new Answers(); 
                }
                
            }

            return a1; 

        }

        public static void Part2()
        {
            int sum = 0; 

            var sr = new StreamReader(@"@../../../../../../input.txt", true);
            int member = 0;
            string temp = null;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                
                if (!String.IsNullOrEmpty(line))
                {
                    member++;
                    temp = temp + line;  
                }
                else
                {
                    var result = temp.GroupBy(c => c).Where(c => c.Count() >= 1).Select(c => new { charName = c.Key, charCount = c.Count() });

                    foreach (var item in result)
                    {
                        if (item.charCount == member)
                        {
                            sum++;
                        }
                    }

                    member = 0;
                    temp = null; 
                }

            }

            Console.WriteLine("Part 2: " + sum);

        }
    }
}
