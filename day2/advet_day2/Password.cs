using System;

namespace advet_day2
{
    public class Password
    {
        public string passwdstring { get; set; }
        public string pwchar { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public bool ValidatePassword_Part1()
        {
            int count = 0; 
            for (int i = 0; i < passwdstring.Length; i++)
                if (Convert.ToString(passwdstring[i]).Equals(pwchar))
                    count++;

            if (count >= min && count <= max)
                return true;
            else
                return false;
        }


        public bool ValidatePassword_Part2()
        {
            bool charCheck1, charCheck2;


            if (Convert.ToString(passwdstring[min-1]).Equals(pwchar)) 
                charCheck1 = true;
            else
                charCheck1 = false;


            if (Convert.ToString(passwdstring[max-1]).Equals(pwchar))    
                charCheck2 = true;
                
            else
                charCheck2 = false;
               

            if (charCheck1 ^ charCheck2)
                return true; 
            else
                return false; 

        }
    }
}
