using System;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (checkingNumberOfArgs(args)) return;
            
            Rules game = new Rules(args.Length);
            string playerTurn;
            int computerTurn;
            bool b;
            Random rand = new Random();
            while (true)
            {
                b = true;
                HMACGenerator generator = new HMACGenerator();


                computerTurn = rand.Next() % args.Length;
                generator.generateHMAC(args[computerTurn]);
                
                listOfMoves(args);
                
                playerTurn = Console.ReadLine();
                if (playerTurn.CompareTo("?") == 0)
                {
                    winConditionsTable.drawTable(args);
                    b = false;
                    continue;
                }
                if (playerTurn.CompareTo("0") == 0) return;
                else for (int i = 0; i < args.Length; i++)
                        if (playerTurn.CompareTo($"{i + 1}") == 0)
                        {
                            Console.WriteLine("Your move: {0}\nComputer move: {1}\n{2}", args[i], args[computerTurn], game.result(i, computerTurn));
                            generator.showKey();
                            b = false;
                            break;
                        }
                if (b) Console.WriteLine("there is no such option!\n\n");
            }
        }


        static bool checkingNumberOfArgs(string [] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("The number of arguments is less than three!");
                return true;
            }
            if(args.Length % 2 == 0)
            {
                Console.WriteLine("Even number of arguments!");
                return true;
            }
            for (int i = 0; i < args.Length - 1; i++)
            {
                for (int j = i + 1; j < args.Length; j++)
                    if (string.Compare(args[i], args[j]) == 0)
                    {
                        Console.WriteLine("the same values");
                        return true;
                    }
            }
            return false;
        }

        static void listOfMoves(string[] moves)
        {
            Console.WriteLine("Available moves:");
            for (int i = 0; i < moves.Length; i++) Console.WriteLine($"{i+1} - {moves[i]}");
            Console.WriteLine("0 - exit\n? - help");
            Console.Write("Enter your move: ");
        }
    }
}
