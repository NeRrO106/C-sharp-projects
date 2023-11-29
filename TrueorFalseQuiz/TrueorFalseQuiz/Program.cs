using System;

/*
In this project, you’ll build a C# program that presents a quiz the right way: using arrays and loops, it will check the format of user input and repeat the question if the format is incorrect. After the quiz is complete, it will check the user’s responses against the correct answers and present a score.
*/

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Type your code below
            string[] questions = { "Pe Pământ există mai multe țări decât limbi vorbite?", "Râul Nil este cel mai lung râu din lume?", "Franța este cel mai mare producător de vin din lume?", "Mona Lisa este un tablou creat de Leonardo da Vinci?", "Orca, cunoscută și sub numele de balena ucigașă, este un tip de balenă?" };
            bool[] answers = { true, true, true, true, false };

            RunQuiz(questions, answers);

        }
        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responds = new bool[answers.Length];

            if (questions.Length != answers.Length) Console.WriteLine("Warning, questions Length != answers Length");

            int index = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool, inputBool;

                Console.WriteLine(question);
                Console.Write("TRUE or FALSE: ");

                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Respond with true/false!");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responds[index] = inputBool;
                index++;
            }
            int scoringIndex = 0, score = 0;

            foreach (bool ans in answers)
            {
                bool temp = responds[scoringIndex];

                Console.WriteLine($"Input:{temp},| Answer: {ans}");

                if (temp == ans) score++;

                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        }
    }
}
