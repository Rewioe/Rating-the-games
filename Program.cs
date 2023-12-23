namespace Rating_the_games;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int Game_num;
            Console.Write("Enter Game num :");
            Game_num = int.Parse(Console.ReadLine());
            Dictionary<string, int> Games_name = new Dictionary<string, int>();
            int j = 0;
            string game;
            while (j < Game_num)
            {
                Console.Write("Enter Game Number " + (j + 1).ToString() + " :");
                game = Console.ReadLine();
                Games_name.Add(game, default(int));
                j++;
            }

            Console.Clear();
            Random randgen = new Random();
            j = 0;
            int l = 0;
            while (j < Games_name.Count)
            {
                while (l < 10)
                {
                    Games_name[Games_name.ElementAt(j).Key] += randgen.Next(0, 10);
                    l++;
                }
                l = 0;
                Console.WriteLine(Games_name.ElementAt(j).Key + " :" + Games_name.ElementAt(j).Value.ToString());
                j++;
            }
            game = null;
            int max = Games_name[Games_name.ElementAt(0).Key];
            while (l < Games_name.Count)
            {
                if (Games_name[Games_name.ElementAt(l).Key] >= max)
                {
                    max = Games_name[Games_name.ElementAt(l).Key];
                    game = Games_name.ElementAt(l).Key;
                }
                l++;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The winner is:" + game);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("with score :" + max);
            Console.ResetColor();
            Console.ReadKey();
        }
        catch
        {
            Console.Clear();
            Console.Write("Ridi ke error dad!");
            Console.ReadKey();
        }
    }
}
