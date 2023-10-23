using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class NewGame
    {
        public static string name;
        public static void GetNameFromPlayer()
        { 
            Console.WriteLine("What name do you give to this person");
            name=Console.ReadLine();
            
        }

    }
}
