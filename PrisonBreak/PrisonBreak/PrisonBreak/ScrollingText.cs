using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisonBreak
{
    class ScrollingText
    {

    }

    public class OutputText
    {
        public string Stuff()
        {


            string a;
            List<string> dogs = new List<string>();
            dogs.Add("ZOMG they're's a BBQ"); // Add string 1
            dogs.Add("Spitz"); // 2
            dogs.Add("Mastiff"); // 3
            dogs.Add("Finnish Spitz"); // 4
            dogs.Add("Briard"); // 5

 
      
   
            a = string.Join(",", dogs.ToArray());

            a = a.Substring(0, a.Length);
            Console.WriteLine(a);
            
            return a;

        }
    
    }



}
