using System;
using System.Collections.Generic;

namespace day6
{
    public class Answers
    {
        public List<string> userAnswers { set; get; } = new List<string>(); 

        public int CountAnswers()
        {
            return this.userAnswers.Count;   
        }

        
    }
}
