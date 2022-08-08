using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            // loops for every character in the text input
            foreach (char c in input)
            {

                bool dontCount = "0123456789.,'/;:()!".IndexOf(c) <= 0;
                // ends analysis when * is found
                if (c.ToString() == "*")
                {
                    break;
                }

                // counts sentances (if no '.'s then it counts as 1 sentance)
                if (c.ToString() == ".")
                {
                    values[0] += 1;
                }
                if (input.IndexOf(".") <= 0)
                {
                    values[0] = 1;
                }

                // counts vowels and consonants
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    values[1] += 1;
                }
                else if (c.ToString() != " " && dontCount)
                {
                    values[2] += 1;
                }

                // counts upper and lower case letters
                if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(c) >= 0)
                {
                    values[3] += 1;
                }
                else if (c.ToString() != " " && dontCount)
                {
                    values[4] += 1;
                }
            }

            return values;
        }
        // Method that handles the individual letter counting 
        public Dictionary<string, int> individualLetters(string text)
        {
            var letters = new Dictionary<string, int>();

            // loops for every character in the text string 
            foreach (char c in text)
            {
                // If the letter is already in the list (lowercase only) the count is incrimented 
                if (letters.ContainsKey(c.ToString().ToLower()))
                {
                    letters[c.ToString().ToLower()]++;
                }

                // if the letter isnt in the dictionary it is added with initial value 1 (ignoring numbers and special characters)
                else if ("0123456789.,'/;:()!*".IndexOf(c) <= 0 && c.ToString() != " ")
                {
                    letters.Add(c.ToString().ToLower(), 1);
                }
                if (c.ToString() == "*")
                {
                    break;
                }
            }
            return letters;
        }
    }
}