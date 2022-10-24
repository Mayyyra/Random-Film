using System;

class Program
{
    public static void Main()
    {
        Film gen = new Film();
        gen.Genre();

    }

    class Film
       {
        Dictionary<int, string> dr = new Dictionary<int, string>()
        {
            [1] = "1+1",
            [2] = "The Help",
            [3] = "The Shawshank Redemption",
            [4] = "...За имя Моё - ...for my Name",
            [5] = "Gattaca",
            [6] = "The Notebook",
            [7] = "The Boy in the Striped Pyjamas",
            [8] = "Hidden Figures",
            [9] = "Одна - The One",
            [10] = "Судьба человека - Fate of a Man",
            [11] = "I Origins"
        };
        Dictionary<int, string> fn = new Dictionary<int, string>()
        {
            [1] = "The Lord of the Rings, 3 parts",
            [2] = "Harry Potter",
            [3] = "The Hobbit",
            [4] = "Maleficent",
            [5] = "Warcraft",
            [6] = "Miss Peregrine's Home for Peculiar Children",
            [7] = "Alice in Wonderland",
            [8] = "Pirates of the Caribbean",
            [9] = "The Mummy",
            [10] = "King Arthur: Legend of the Sword",
            [11] = "Snow White and the Huntsman",
            [12] = "Constantine",
            [13] = "The Chronicles of Narnia"
        };
        Dictionary<int, string> thr = new Dictionary<int, string>()
        {
            [1] = "Limitless",
            [2] = "Shutter Island",
            [3] = "Split",
            [4] = "The Shining",
            [5] = "Doctor Sleep",
            [6] = "A Cure for Wellness",
            [7] = "Midsommar",
            [8] = "Fight Club",
            [9] = "Seven",
            [10] = "The Silence of the Lambs",
            [11] = "Gone Girl",
            [12] = "The Prestige",
            [13] = "The Da Vinci Code",
            [14] = "The House That Jack Built"
        };

        public void Genre()
        {
            Random rand = new Random();

            Console.WriteLine("Please select the genre of the movie. Currently, the following genres are available: drama, thriller and fantasy. ");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "drama":
                    int rnd = rand.Next(1, dr.Count + 1);
                    string film = dr[rnd];
                    Console.WriteLine($"The genre you have chosen: {option}. Recommended movie for you: {film}.");
                    break;
                case "fantasy":
                    int rnd1 = rand.Next(1, fn.Count + 1);
                    string film1 = fn[rnd1];
                    Console.WriteLine($"The genre you have chosen: {option}. Recommended movie for you: {film1}.");
                    return ;
                case "thriller":
                    int rnd2 = rand.Next(1, thr.Count + 1);
                    string film2 = thr[rnd2];
                    Console.WriteLine($"The genre you have chosen: {option}. Recommended movie for you: {film2}.");
                    break;
                default:
                    Console.WriteLine("There is no such genre in the database, sorry.");
                    break;
            };
            }
        }
}
