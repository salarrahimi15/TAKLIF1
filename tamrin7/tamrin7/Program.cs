namespace tamrin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Welcome! Let's find out if you might be a programmer.");

            for (int i = 1; i <= 5; i++)
            {
                string answer = "";

                switch (i)
                {
                    case 1:
                        Console.WriteLine("1: Aya to danshamozi? (yes/no)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes") score++;
                        break;

                    case 2:
                        Console.WriteLine("2: Aya to danshjoyi? (yes/no)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes") score++;
                        break;

                    case 3:
                        Console.WriteLine("3: Aya to shoghli dari? (yes/no)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes") score++;
                        break;

                    case 4:
                        Console.WriteLine("4: Aya to daramad dari? (yes/no)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes") score++;
                        break;

                    case 5:
                        Console.WriteLine("5: Aya to ezdevaj kardi? (yes/no)");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes") score++;
                        break;
                }
            }

            
            if (score >= 4)
            {
                Console.WriteLine("To be arzot residi.");
            }
            else
            {
                Console.WriteLine("Bro pey dars va mashghat, bache!");
            }

        }
    }
}
