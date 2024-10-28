
using System;
class Program
{
    static void Main(string[] args)
    {

        
        Scripture newScripture = new Scripture();

        bool runAgain = true;
        string userCommand = "";
        while (runAgain)
        {

            // newScripture.CheckText
            if (newScripture.CheckText() == true)
            {
                runAgain = false;
            }

            newScripture.Display();

            Console.WriteLine();
            userCommand = Console.ReadLine();

            newScripture.HideWords();

            if (userCommand == "quit")
            {
                runAgain = false;
            }
        }
        
    }
}