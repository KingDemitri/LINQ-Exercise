using System.IO;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Games> videogames = new List<Games>();//("Kingdom Hearts, Kingdom Hearts II, Kingdom Hearts II: Final Mix");

            videogames.Add(new Games() { GameName = "Kingdom Hearts", ReleaseOrder = "1st", ChronOrder = 2 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts Final Mix", ReleaseOrder = "2nd", ChronOrder = 3 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts II", ReleaseOrder = "3rd", ChronOrder = 4 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts II: Final Mix", ReleaseOrder = "4th", ChronOrder = 5 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts: Chain of Memories", ReleaseOrder = "5th", ChronOrder = 3 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts X", ReleaseOrder = "6th", ChronOrder = 1 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts 0.2: A Fragmentary Passage", ReleaseOrder = "7th", ChronOrder = 2 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts 358/2 Days", ReleaseOrder = "8th", ChronOrder = 6 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts: RE:coded", ReleaseOrder = "9th", ChronOrder = 1 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts: Chain of Memories", ReleaseOrder = "10th", ChronOrder = 1 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts Dream Drop Distance", ReleaseOrder = "11th", ChronOrder = 10 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts 3", ReleaseOrder = "12th", ChronOrder = 13 });
            videogames.Add(new Games() { GameName = "Kingdom Hearts: Birth By Sleep", ReleaseOrder = "12th", ChronOrder = 12 });

            Console.WriteLine("Sorted by Release Order");
            videogames.OrderBy(x => x.ChronOrder).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted by Release Order:");

            videogames.OrderBy(x => x.ReleaseOrder).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();

            IEnumerable<Games> sortedList = videogames.OrderByDescending(x => x.ReleaseOrder).ToList();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);   
            }
        }
    }
}

//Create a list of video game names...
//    Order the list of games by length of the game name.
//    Use the lambda expression in this exercise as well.

//        use Method Syntax for this exercise