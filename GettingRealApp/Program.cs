using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealApp
{
    class Program
    {


        public static void showList()
        {
            string[,] array = new string[6, 5]
        {
        {"Id", "Firstname", "Lastname", "Position", "Adress"},
        {"1", "David", "Bertus", "Attacker", "Somewhere near school"},
        {"2", "Alex", "Cehan", "Goalkeeper", "Not that close to school"},
        {"3", "Alex", "Damsted", "Midfielder", "Kiwi street, New Zeeland"},
        {"4", "Roxana", "Ion", "Central", "Somewhere else"},
        {"5", "Nikolaj", "Morup", "Center-Back", "Somewhere but not at school :( "}
        };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(array[i, 0]+ " " + array[i, 1] + " " + array[i, 2] + " " + array[i, 3] + " " + array[i, 4]);
            }
        }

        static void Main(string[] args)
        {
            string comand;
            comand = Console.ReadLine();
            if (comand == "list")
            {
                showList();
            }
            Console.ReadKey();
        }
    }
}
