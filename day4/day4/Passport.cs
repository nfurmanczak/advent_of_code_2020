using System;
namespace day4
{
    public class Passport
    {
        public string byr { set; get; }
        public string iyr { set; get; }
        public string eyr { set; get; }
        public string hgt { set; get; }
        public string hcl { set; get; }
        public string ecl { set; get; }
        public string pid { set; get; }
        public string cid { set; get; }

        public bool CheckValidPassport()
        {
            if(!String.IsNullOrEmpty(byr) &&
               !String.IsNullOrEmpty(iyr) &&
               !String.IsNullOrEmpty(eyr) &&
               !String.IsNullOrEmpty(hgt) &&
               !String.IsNullOrEmpty(hcl) &&
               !String.IsNullOrEmpty(ecl) &&
               !String.IsNullOrEmpty(pid))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public bool CheckBYR()
        {
            int ibyr; 
            if(Int32.TryParse(this.byr, out ibyr))
            {
                if (ibyr >= 1920 && ibyr <= 2002)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
                       
            }
            else
            {
                return false; 
            }
        }
    }
}
