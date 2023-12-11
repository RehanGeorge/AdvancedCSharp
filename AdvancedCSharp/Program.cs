namespace AdvancedCSharp
{
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
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 4.5;
            game1.releaseDate = "July 6, 2016";

            game1.Display();            
        }
    }
}
