using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class MainMenu
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("1:New Game");
            Console.WriteLine("2:About Me");
            Console.WriteLine("3:Exit");
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    NewGame.GetNameFromPlayer();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Im a devloper who made this game for fun :)");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry not a valid option try again");
                    DisplayMainMenu();
                    break;

            }
        }
    }
}
