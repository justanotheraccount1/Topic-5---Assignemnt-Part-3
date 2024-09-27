using System.Diagnostics;

namespace Topic_5___Assignemnt_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/26/24

            int answer1, points;
            string answer2;

            Console.WriteLine("Welcome to The Impossible Quizz!!");
            Console.WriteLine("No one can get all 5 questions correct.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue...");
            Console.ReadLine();
            Console.Clear();

            points = 0;
            //Question 1
            
            Console.WriteLine("Ok... I'll be nice and give you an easy one to start.");
            Console.WriteLine();
            Console.WriteLine("Question 1:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How many countries are in the continent of Africa?");
            Console.WriteLine();
            Console.WriteLine("Please input your answer as a number:");
            int.TryParse(Console.ReadLine(), out answer1);

            if (answer1 == 52)
            {
                Console.WriteLine("That is correct");
                points = (points + 1);
            }
                

            else
                Console.WriteLine("That is incorrect. The answer we were looking for was: 52");


            Console.WriteLine("Press ENTER to Continue...");
            Console.ReadLine();
            Console.Clear();

            int commonLetter = 114;
            //Question 2
            Console.WriteLine("Question 2:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the third most Frequently Used Letter in the English" +
                " Language?");
            Console.WriteLine();
            Console.WriteLine("Please input your answer as a single character:");
            answer2 = Console.ReadLine().ToLower();
            if (answer2[0] == (char)commonLetter)
            {
                Console.WriteLine($"That is correct. The letter '{(char)commonLetter}' is used in 7.58% of all " +
                    "English words!");
                points = (points + 1);
            }
            else if (answer2 == "q" || answer2 == "j" || answer2 == "z" || answer2 == "x" || answer2 == "v")
            {
                Console.WriteLine(answer2 + " is one of the LEAST used answers!");
                Console.WriteLine("You will now loose a point due to your stupidity");
                points -= 1;
            }
            else if (answer2 == "e" || answer2 == "a")
                Console.WriteLine("Good try, but " + answer2 + "is actually more frequently used" +
                    $" than the answer we were looking for which was '{(char)commonLetter}'.");
            else if (answer2 == "i" || answer2 == "o" || answer2 == "t" || answer2 == "n" || answer2 == "s" || answer2 == "l" || answer2 == "c")
            {
                Console.WriteLine(answer2 + " is unfortunatley not the right answer...");
                Console.WriteLine("However, it is one of the Top 10 Most Used letters.");
                Console.WriteLine($"The answer we were looking for was '{(char)commonLetter}'");
            }
            else if (answer2 == "u" || answer2 == "d" || answer2 == "p" || answer2 == "m" || answer2 == "h" || answer2 == "g" || answer2 == "b" || answer2 == "f" || answer2 == "y" || answer2 == "w" || answer2 == "k")
                Console.WriteLine($"Incorrect. The answer we were looking for was '{(char)commonLetter}'");
            else
            {
                Console.WriteLine("THAT'S NOT EVEN A LETTER! YOU WILL NOW LOSE 2 POINTS.");
                points -= 2;
                Console.WriteLine($"The correct answer was '{(char)commonLetter}");
            }

            Console.WriteLine("Press ENTER to Continue...");
            Console.ReadLine();
            Console.Clear();

            //Question 3









        }
    }
}
