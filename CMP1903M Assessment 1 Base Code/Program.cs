
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {

        static void Main()
        {

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            string text = "nothing";
          
            while (true)
            {
                // Options for the users

                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(">>>>>>>>>Manual and File Text Analysis<<<<<<<<<");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Please Select the Option shown below:-");
                Console.WriteLine();
                Console.WriteLine("1) Manual text ");
                Console.WriteLine("2) File");
                Console.WriteLine("3) Quit");
                string userchoice = Console.ReadLine();
                // if 1 then goes directly to manual text input
                if (userchoice == "1")
                {
                    Input userInput = new Input();
                    text = userInput.manualTextInput();

                }
                // if 2 then goes directly to file input
                else if (userchoice == "2")
                {
                    Input userInput = new Input();
                    Console.WriteLine("Enter File Name");
                    string filename = Console.ReadLine();
                    text = userInput.fileTextInput(filename);

                }
                // Typing 3 on a keyboard will Quit the program
                else if (userchoice == "3")
                {
                    Console.WriteLine("Program closed");
                    break;
                }
                // blank space makes the user re enter the value
                else if (userchoice == "")
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                // anything else also makes them re enter the value 
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;

                }

                Analyse a = new Analyse();
                //Pass the text input to the 'analyseText' method
                //Receive a list of integers back
                List<int> values = a.analyseText(text);


                //Report the results of the analysis
                Report r = new Report();
                r.results(values);

                //Calculates the individual values and asks the user if they wish to view them
                r.ILetters(a.individualLetters(text));



            }

        }
    }
}