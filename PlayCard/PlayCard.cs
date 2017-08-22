using System;

class PlayCard
{
    static void Main()
    {
        string playcard = Console.ReadLine();

        switch (playcard)
        {
            case "2": Console.WriteLine("yes {0}", playcard); break;
            case "3": Console.WriteLine("yes {0}", playcard); break;
            case "4": Console.WriteLine("yes {0}", playcard); break;
            case "5": Console.WriteLine("yes {0}", playcard); break;
            case "6": Console.WriteLine("yes {0}", playcard); break;
            case "7": Console.WriteLine("yes {0}", playcard); break;
            case "8": Console.WriteLine("yes {0}", playcard); break;
            case "9": Console.WriteLine("yes {0}", playcard); break;
            case "10": Console.WriteLine("yes {0}", playcard); break;
            case "J": Console.WriteLine("yes {0}", playcard); break;
            case "Q": Console.WriteLine("yes {0}", playcard); break;
            case "K": Console.WriteLine("yes {0}", playcard); break;
            case "A": Console.WriteLine("yes {0}", playcard); break;
            default:
                Console.WriteLine("no {0}", playcard);
                break;
        }
    }
}

