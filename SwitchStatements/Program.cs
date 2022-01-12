using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Welcome back. I got one question and one question only. What is your favorite school subject? (LETTERS ONLY!!!) :)");
            var subject = Console.ReadLine().ToLower();

            switch(subject)
            {
                case "math":
                case "algebra":
                case "calculus":
                case "geometry":
                case "statistics":
                    Console.WriteLine("Wow! Thats probably super good and fun for you! Math was too easy for me. I'm a computer!");
                    break;

                case "science":
                case "earth science":
                case "geology":
                    Console.WriteLine("Big EArth guy huh?!? Bet you think that makes you smart and good. Well, it does.");
                    break;

                case "lunch":
                    Console.WriteLine("HAHAHahahaHAHa I have never felt the feel of food betwixt my teeth. I'm a COMPUTER");
                    break;

                case "history":
                case "social studies":
                case "civics":
                case "government":
                    Console.WriteLine("That thing make zero sense to me. Humans confuse me. I am literally better than you. All.");
                    break;

                case "recess":
                    Console.WriteLine("You are literally a cop now.");
                    break;

                default:
                    Console.WriteLine("EH try writing something else. My tiny computer mind can only handle so much stuff.");
                    break;
            }
        }
    }
}
