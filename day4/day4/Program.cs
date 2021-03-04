using System;
using System.Collections.Generic;
using System.IO;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sortedList = Import();
            List<Passport> pList = new List<Passport>(); 
            string byr = null;
            string iyr = null;
            string eyr = null;
            string hgt = null;
            string hcl = null;
            string ecl = null;
            string pid = null;
            string cid = null; 

            foreach (var line in sortedList)
            {


                Passport passport = new Passport();
                if (!line.Contains("####"))
                {
                    var b1 = line.Split(':');
                    if (b1[0].Equals("byr"))
                    {
                        //Console.WriteLine(b1[0] + " => " +b1[1]);
                        byr = b1[1];
                    }
                    else if (b1[0].Equals("iyr"))
                    {
                        //Console.WriteLine(b1[0] + " => " + b1[1]);
                        iyr = b1[1];
                    }

                    else if (b1[0].Equals("eyr"))
                    {
                        //Console.WriteLine(b1[0] + " => " + b1[1]);
                        eyr = b1[1];
                    }

                    else if (b1[0].Equals("hgt"))
                    {
                        //Console.WriteLine(b1[0] + " => " + b1[1]);
                        hgt = b1[1];
                    }

                    else if (b1[0].Equals("hcl"))
                    {
                        // Console.WriteLine(b1[0] + " => " + b1[1]);
                        hcl = b1[1];
                    }
                    else if (b1[0].Equals("ecl"))
                    {
                        // Console.WriteLine(b1[0] + " => " + b1[1]);
                        ecl = b1[1];
                    }

                    else if (b1[0].Equals("pid"))
                    {
                        //Console.WriteLine(b1[0] + " => " + b1[1]);
                        pid = b1[1];
                    }

                    else if (b1[0].Equals("cid"))
                    {
                        //Console.WriteLine(b1[0] + " => " + b1[1]);
                        cid = b1[1];
                    }
                }
                else
                {
                    Passport p = new Passport();
                    p.byr = byr;
                    p.iyr = iyr;
                    p.eyr = eyr;
                    p.hgt = hgt;
                    p.hcl = hcl;
                    p.ecl = ecl;
                    p.pid = pid;
                    p.cid = cid;
                    pList.Add(p);
                    byr = null;
                    iyr = null;
                    eyr = null;
                    hgt = null;
                    hcl = null;
                    ecl = null;
                    pid = null;
                    cid = null;
                }
            }


            int counter = 1;
            foreach (var item in pList)
            {
                if(item.CheckValidPassport())
                {
                    counter++;
                }
            }

            Console.WriteLine("Valid: " + counter);
        }

        public static List<string> Import()
        {
            List<string> sortList = new List<string>(); 

            var sr = new StreamReader(@"@../../../../../../input.txt", true);

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    

                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] a1 = line.Split(' ');

                        for (int i = 0; i < a1.Length; i++)
                        {
                            var b1 = a1[i].Split(':');
                            sortList.Add(b1[0]+":"+b1[1]); 
                        }

                    }
                    else
                    {
                        sortList.Add("####"); 
                    }

                }
                
                return sortList;
        }
    }
}
