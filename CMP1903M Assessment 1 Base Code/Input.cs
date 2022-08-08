using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        // Method: manualTextInput
        // Arguments: None
        // Returns: String
        // Gets text Input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Manual Text Input: ");
            text = Console.ReadLine();

            // If it's null it will make text none and then return it.
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Manual Text Input cannot be empty of null.");
            }
            else
            {
                return text;
            }
        }

        // Method: getText
        // Arugements: None
        // Returns: string
        // Returns the text to the program/analysis
        public string getText()
        {
            return text;
        }

        // Method: fileTextInput
        // Arguments: String (the file path)
        // Returns: String
        // Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader("../../../Text.txt");
                string data = sr.ReadToEnd();
                text = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Not Found!" + ex.Message +
                "\nRestart the program and see if the text is in the same file as CMP1903M.");
            }
            finally
            {
                Console.WriteLine("Found the file.");
            }
            return text;
        }
    }
}