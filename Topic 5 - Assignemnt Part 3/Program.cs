using System.Diagnostics;

namespace Topic_5___Assignemnt_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/26/24

            int answer1, points, answer3, randNum, bonusAnswer, randNum2, wager;
            string answer2, answer4;
            Random generator = new Random();

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

            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue...");
            Console.ReadLine();
            Console.Clear();

            //Question 3

            Console.WriteLine("Question 3:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Guess the random number I am thinking of from 1-100");
            randNum = generator.Next(1, 101);
            int.TryParse( Console.ReadLine(), out answer3);
            if (answer3 != randNum)
            {
                Console.WriteLine("Unfortunatly that is incorrect...");
                Console.WriteLine("The correct answer was " + randNum);
            }
        
            else
            {
                Console.WriteLine("WHHAAAAAAA!!!!!!!!! HOW DID YOU GUESS THAT RIGHT????");
                points += 1;
                Console.WriteLine("I can't believe it... OK OK.. How about this... " +
                    "Double or Nothing... It'll be like a 'bonus question'...");
                //Bonus Question
                Console.WriteLine("Alright... Bonus time... Guess the random number between 1 " +
                    "and 100 for 1000 points, and the chance to win the game...");
                randNum2 = generator.Next(1, 101);
                int.TryParse(Console.ReadLine(), out bonusAnswer);
                if (bonusAnswer == randNum2)
                {
                    Console.WriteLine("I have no words... you just did something that only " +
                        "happens ONCE every TEN THOUSAND TRIES!!!!!");
                    Console.WriteLine("How? You must be cheating right?");
                    Console.WriteLine("Anyways... here's your 1000 points... enjoy it... you " +
                        "just won.");
                    points += 1000;
                    Console.WriteLine("Please humor me by answering this final question.");

                } 
                else
                {
                    Console.WriteLine("Unfortunatly that is incorrect...");
                    Console.WriteLine("The correct answer was " + randNum);
                    Console.WriteLine("You lose your points because you lost the deal");
                    points -= 1;
                }


            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue...");
            Console.ReadLine();
            Console.Clear();


            //Question 4

            Console.WriteLine("Question 4:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This question is VERY DIFFICULT... and that's saying something.");
            Console.WriteLine();

            Console.WriteLine("You can now wager all the points that you have for this final " +
                "question.");

            Console.WriteLine();
            Console.WriteLine("If you get it right... you will recieve as many points as you " +
                "wagered...");

            Console.WriteLine("If you don't... you will lose the points that you wager.");
            Console.WriteLine("You must wager at least 1 point.");

            Console.WriteLine("If you have no points... you will recieve a bonus point to " +
                "participate in this final question:");

            if (points == 0)
                points += 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("How many points will you wager?");

            int.TryParse(Console.ReadLine(), out wager);
            if (wager > points || wager < 1)
            {
                Console.WriteLine("You didn't follow the rules, and you will now wager all of your points");
                wager = points;
                Console.WriteLine();
            }
            Console.WriteLine("Now here's the question...");
            Console.WriteLine();
            Console.WriteLine("What is the longest word in the English language?");
            Console.WriteLine("Spell it correctly to win.");

            answer4 = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (answer4 == "pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                Console.WriteLine("That is correct.");
                points += wager;
            }
            else
            {
                Console.WriteLine("That is incorrect. The correct answer was 'Pneumonoultramicroscopicsilicovolcanoconiosis'.");
                points -= wager;
            }
            Console.WriteLine("Congradulations on reaching the end of the quiz!");
            Console.WriteLine("You finished with " + points + "points");

            if (points == 2006)
            {
                Console.WriteLine("You got the most points possible...");
                Console.WriteLine("You are a quizz GOD");
            }
            else if (points >= 5)
                Console.WriteLine("You passed the quiz. Good job.");
            
            else
                Console.WriteLine("You did not pass the quiz... better luck next time.");
            Console.ReadLine();













        }
    }
}
