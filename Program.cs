using System;
using System.Text.RegularExpressions;
namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            string input = "abbb"; 
            
            string pattern = @"a(bb{2,3})";
            
            Regex regex = new Regex(pattern);
            
            if (regex.IsMatch(input))
            {
                Console.WriteLine("Input string matches the pattern.");
            }
            else
            {
                Console.WriteLine("Input string does not match the pattern.");
            }


            //2.
            Console.WriteLine("Enter a string: ");
            string input1 = Console.ReadLine();
           
            string pattern1 = @"[a-z]+(_[a-z]+)+";

            Regex regex1 = new Regex(pattern1);
           
            MatchCollection matches = regex1.Matches(input1);
           
            if (matches.Count > 0)
            {
                Console.WriteLine("Matched sequences of lowercase letters joined by underscores:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. No matched sequences found.");
            }


            //3.
            string input2 = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            
            string pattern2 = @"<[^>]+>";
            
            Regex regex2 = new Regex(pattern2);
            
            MatchCollection matches1 = regex2.Matches(input2);
            
            foreach (Match match in matches1)
            {
                Console.WriteLine(match.Value);
            }


            //4.
            string pattern3 = @"fox(es)?"; 
            string input3 = "foxes are omnivorous mammals belonging to several generaof the family Canidae fox.";
            Regex regex3 = new Regex(pattern3);
            
            MatchCollection matches2 = regex3.Matches(input3);
            
            int count = matches2.Count;
            
            Console.WriteLine("There are " + count + " occurrences.");


            //5.
            Console.WriteLine("Enter a space-separated list of file names: ");
            string input4 = Console.ReadLine();
            
            string pattern4 = @"\b\w+\.(jpg|jpeg|png|gif|bmp)\b";
            
            Regex regex4 = new Regex(pattern4, RegexOptions.IgnoreCase);
           
            MatchCollection matches3 = regex4.Matches(input4);
           
            if (matches3.Count > 0)
            {
                Console.WriteLine("Valid image file names:");
                foreach (Match match in matches3)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No valid image file names found.");
            }


            //6.
            Console.WriteLine("Enter a website address (URL): ");
            string input5 = Console.ReadLine();
            
            string pattern5 = @"^(https?://)?(www\.)?[\w-]+\.[a-z]+(/[/?%&=]*)?$";
            
            Regex regex5 = new Regex(pattern5, RegexOptions.IgnoreCase);
            
            if (regex5.IsMatch(input5))
            {
                Console.WriteLine("Valid website address.");
            }
            else
            {
                Console.WriteLine("Invalid website address.");
            }
        }
    }    
}