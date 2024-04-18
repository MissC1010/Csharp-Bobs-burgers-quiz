using System;

namespace BobsBurgersQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bobs Burgers Quiz");
            Console.WriteLine("How well do you know Bob and his family?");
            Console.WriteLine("Are you a true 'Bobeliever' in Bob's Burgers?");
            Console.WriteLine();

            int score = 0;


            // Question 1
            Console.WriteLine("Question 1: What is the name of Bob's wife?");
            Console.WriteLine("a) Linda");
            Console.WriteLine("b) Tina");
            Console.WriteLine("c) Louise");
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "a")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.WriteLine();

            // Question 2
            Console.WriteLine("Question 2: What is the name of Bob's eldest daughter?");
            Console.WriteLine("a) Tina");
            Console.WriteLine("b) Linda");
            Console.WriteLine("c) Louise");
            Console.Write("Your answer: ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "a")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.WriteLine();

            // Question 3
            Console.WriteLine("Question 3: What is the name of the restaurant across the street from Bob's Burgers?");
            Console.WriteLine("a) Jimmy Pesto's Pizza Parlor");
            Console.WriteLine("b) Jimmy Pesto's Pizzeria");
            Console.WriteLine("c) Pesto's Pizza Emporium");
            Console.Write("Your answer: ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "b")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.WriteLine();

            // Question 4
            Console.WriteLine("Question 4: What is the name of Linda's sister");
            Console.WriteLine("a) Gayel");
            Console.WriteLine("b) Gayle");
            Console.WriteLine("c) Gail");
            Console.Write("Your answer: ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "b")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.WriteLine();

            // Question 5
            Console.WriteLine("Question 5: Who believes they are BEST FRIENDS with louise");
            Console.WriteLine("a) Regular sized Rudy");
            Console.WriteLine("b) Andy and Ollie");
            Console.WriteLine("c) Millie");
            Console.Write("Your answer: ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "c")
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            Console.WriteLine();



            // Display score
            Console.WriteLine("Quiz complete! Now buy a burger or get out.");
            Console.WriteLine($"Your score: {score} out of 5");
        }
    }
}
