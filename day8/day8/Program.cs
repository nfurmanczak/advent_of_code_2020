using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BasicCode> Code = new List<BasicCode>(); 

            var sr = new StreamReader(@"@../../../../../../input.txt", true );

            while (!sr.EndOfStream)
            {
                BasicCode c1 = new BasicCode(); 
                string line = sr.ReadLine();
                var x = line.Split(' ');
                c1.operation = x[0].Trim();
                c1.used = 0; 

                if (x[1].Contains('-'))
                {
                    c1.value = Convert.ToInt32(x[1].Remove(0, 1))*-1; 
                }
                else
                {
                    c1.value = Convert.ToInt32(x[1].Remove(0, 1));
                }

                Code.Add(c1);
            }


            
            int accValue = 0; 
            
            int i = 0;
            Console.WriteLine(Code.Count);
            Console.ReadLine(); 

            while (i < Code.Count)
            {
                Console.WriteLine("Counter: "+  i);

                if (Code[i].operation == "acc" && Code[i].used == 0)
                {
                    accValue = accValue + Code[i].value;
                    Code[i].used = 1;
                    i++;
                }

               else if (Code[i].operation == "nop" && Code[i].used == 0)
                {
                   
                    Code[i].used = 1;
                    i++;
                }

                else if (Code[i].operation == "jmp" && Code[i].used == 0)
                {
                    Code[i].used = 1;
                    i = i + Code[i].value;
                    
                }
                else
                {
                    Console.WriteLine("Part 1: " + accValue);
                    break; 
                }

               
            }

        }
    }
}


