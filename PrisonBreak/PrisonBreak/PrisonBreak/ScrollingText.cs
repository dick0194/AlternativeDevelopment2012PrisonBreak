﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisonBreak
{
    class ScrollingText
    {

    }

    public class EndsWithTest
    {
        public static void Stuff()
        {

            // process an input file that contains html tags. 
            // this sample checks for multiple tags at the end of the line, rather than simply 
            // removing the last one. 
            // note: HTML markup tags always end in a greater than symbol (>). 

            string[] strSource = { "<b>This is bold text</b>", "<H1>This is large Text</H1>",
                "<b><i><font color=green>This has multiple tags</font></i></b>",
                "<b>This has <i>embedded</i> tags.</b>",
                "This line simply ends with a greater than symbol, it should not be modified>" };

            Console.WriteLine("The following lists the items before the ends have been stripped:");
            Console.WriteLine("-----------------------------------------------------------------");

            // print out the initial array of strings 
            foreach (string s in strSource)
                Console.WriteLine(s);

            Console.WriteLine();

            Console.WriteLine("The following lists the items after the ends have been stripped:");
            Console.WriteLine("----------------------------------------------------------------");

            // print out the array of strings 
            foreach (string s in strSource)
                Console.WriteLine(StripEndTags(s));
        }

        private static string StripEndTags(string item)
        {

            // try to find a tag at the end of the line using EndsWith 
            if (item.Trim().EndsWith(">"))
            {

                // now search for the opening tag... 
                int lastLocation = item.LastIndexOf("</");

                // remove the identified section, if it is a valid region 
                if (lastLocation >= 0)
                    item = item.Substring(0, lastLocation);
            }

            return item;
        }
    }

}