using System;
using System.Collections.Generic;
using System.IO;

namespace advet_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Password> pwList = ImportList();

            int counter =0, counter2 = 0;
            
            foreach (var p in pwList)
            {
                if (p.ValidatePassword_Part1())
                    counter++;
            }


            foreach (var p in pwList)
            {
                if (p.ValidatePassword_Part2())
                    counter2++; 
            }

            Console.WriteLine("Correct Passwords for Part 1: " + counter);
            Console.WriteLine("Correct Passwords for Part 2: " + counter2);
            Console.ReadLine(); 

        }



        static public List<Password> ImportList()
        {
            List<Password> pwList = new List<Password>();

            using (var sr = new StreamReader(@"@../../../../../../password.txt", true))
            {
        
                while (!sr.EndOfStream)
                {
                    Password p = new Password();
                    var line = sr.ReadLine().Split(':');
                    var pwPolicy = line[0].Trim().Split(' ');
                    var pwValues = pwPolicy[0].Trim().Split('-');

                    p.min = Convert.ToInt32(pwValues[0]);
                    p.max = Convert.ToInt32(pwValues[1]);
                    p.pwchar = pwPolicy[1].Trim();
                    p.passwdstring = line[1].Trim();

                    pwList.Add(p); 

                }

                return pwList; 
            }
        }
    }
}
