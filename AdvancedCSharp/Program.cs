using System.Runtime.CompilerServices;
using System.IO;
using System.Text.RegularExpressions;

namespace AdvancedCSharp
{
    //enums

    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul=12, Aug, Sep, Oct, Nov, Dec };

    // Structs do not support inheritance, but they can implement interfaces.
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine($"Game 1's name is {name}");
            Console.WriteLine($"Game 1's developer is {developer}");
            Console.WriteLine($"Game 1's rating is {rating}");
            Console.WriteLine($"Game 1's release date is {releaseDate}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 4.5;
            game1.releaseDate = "July 6, 2016";

            game1.Display();            
            */

            /*
            Day fr = Day.Friday;
            Day su = Day.Sunday;

            Day a = Day.Friday;

            Console.WriteLine(fr==a);
            Console.WriteLine((int)Month.Aug);

            Console.WriteLine($"Ceiling: {Math.Ceiling(15.3)}");
            Console.WriteLine($"Floor: {Math.Floor(15.3)}");

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine($"Lower of {num1} and {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher of {num1} and {num2} is {Math.Max(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}");
            Console.WriteLine($"PI is {Math.PI}");
            Console.WriteLine($"Always positive is {Math.Abs(-25)}");
            Console.WriteLine($"Cos of 1 is {Math.Cos(1)}");
            */

            /*
            //Random
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

            int fortune = dice.Next(1, 4);
            string response = fortune == 1 ? "Yes" : fortune == 2 ? "No" : "Maybe";
            Console.WriteLine(response);
            */

            RegEx();
        }
        public static void RegEx()
        {
            //Read from a file
            string[] text = File.ReadAllLines(@"C:\Users\Rehan George\source\repos\AdvancedCSharp\Sample.txt");

            string pattern = @"\d{3}-\d{3}-\d{4}";

            foreach (string line in text)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(line, pattern))
                {
                    Console.WriteLine(line);
                }
            }

            Regex regex = new Regex(pattern);

            string test = "My number is 123-456-7890";
            MatchCollection matchCollection = regex.Matches(test);

            Console.WriteLine(matchCollection.Count);

            foreach (Match m in matchCollection)
            {
                GroupCollection groupCollection = m.Groups;
                Console.WriteLine($"{groupCollection[0].Value} found at {groupCollection[0].Index}");
            }
        }
    }
}
