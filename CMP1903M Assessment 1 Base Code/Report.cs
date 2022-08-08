using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void results(List<int> values)
        {
            Console.WriteLine("");
            Console.WriteLine("Number of sentances: " + values[0]);
            Console.WriteLine("Number of vowels: " + values[1]);
            Console.WriteLine("Number of consonants: " + values[2]);
            Console.WriteLine("Number of upper case letters: " + values[3]);
            Console.WriteLine("Number of lower case letters: " + values[4]);
            Console.WriteLine("");
        }

        public void ILetters(Dictionary<string, int> letters)
        {
            string choice = "";
            while (choice != "y" && choice != "n" && choice != "yes" && choice != "no")
            {
                Console.Write("If you wish view the individual letter frequency, Type (Yes)! ");
                choice = Console.ReadLine();

            }
            // Type "yes" to view the frequency
            if (choice == "y" || choice == "yes")
            {
                foreach (var pair in letters)
                {
                    Console.Write(pair.Key);
                    Console.Write(" - ");
                    Console.WriteLine(pair.Value);
                }
            }
        }

    }
}