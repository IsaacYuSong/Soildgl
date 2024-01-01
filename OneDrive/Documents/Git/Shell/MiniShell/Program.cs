using System.Xml.Linq;

namespace MiniShell
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                string[] words = input.Split(" ");
                switch(words[0])
                {
                    
                    case "cd":
                        if (words.Length > 1) 
                        {
                            Commands.Cd(words[1]);
                        }
                        else
                        {
                            Commands.Cd();
                        }
                        break;
                    case "dir":
                        if(words.Length > 1)
                        {
                            Commands.Dir(words[1]);
                        }
                        else
                        {
                            Commands.Dir();
                        }
                        
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "whoami":
                        Commands.WhoAmI();
                        break;
                    default:
                        Console.WriteLine($"Command {words[0]} not found");
                        break;
                }
            }

        }

    }
}
