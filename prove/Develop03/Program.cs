using System;
using System.Collections.Generic;

class Program
{

    private static readonly Random rand = new Random();
    //Encapsulation logic in private field of rand
    //generates random values
    //internal implementation is hidden 
    //since cant be accessed outside Program class

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        // Define a collection of Scriptures
        var MyFavScriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him and he will make your paths straight."),
            new Scripture("Philippians 4:13", "I can do all this through him who gives me strength."),
            new Scripture("Psalm 91:1-2", "He that dwelleth in the secret place of the most High shall abide under the shadow of the Almighty. I will say of the Lord, He is my refuge and my fortress: my God; in him I trust."),
            new Scripture("Matthew 11:28", "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture("John 8:36", "If the Son therefore shall make you free, ye shall be free indeed.")
        };

        bool continueProgram = true;

        while (continueProgram)
        {
            // randomly a scripture is chosen
            var selectedScripture = MyFavScriptures[rand.Next(MyFavScriptures.Count)];

            // Step 1: Display the scripture
            selectedScripture.Display();
            
            Console.WriteLine();
            // Step 2: Hide random words and prompt user until all words are hidden
            while (!selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press Enter to hide some words and memorize the scripture, or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    continueProgram = false;
                    break;
                }

                // Hide words and display scripture
                selectedScripture.HideRandomWords(4); // 4 random words will be hidden after press enter
                selectedScripture.Display();
            }

            if (!continueProgram)
            {
                break;
            }

            // Step 3: When all words are hidden, prompt the user to continue or quit
            Console.WriteLine("All words are hidden.");
            Console.WriteLine("Press 'c' to continue with a new scripture or 'q' to quit.");
            while (true)
            {
                string NextOrExit = Console.ReadLine();
                if (NextOrExit.ToLower() == "q")
                {
                    continueProgram = false;
                    Console.WriteLine("Nice try! Keep memorizing.");
                    break;
                }
                else if (NextOrExit.ToLower() == "c")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press 'c' to continue or 'q' to quit.");
                }
            }
        }

        
        Console.WriteLine("make it fun to memorize 2scriptures a day ");
        Console.WriteLine("BBB");
    }
}
