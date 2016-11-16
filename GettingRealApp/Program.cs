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
            string[,] vector = new string[6, 5]
            {
        {"Id", "Firstname", "Lastname", "Position", "Adress"},
        {"1", "David", "Bertus", "Attacker", "Somewhere near school"},
        {"2", "Alexandru", "Cehan", "Goalkeeper", "Not that close to school"},
        {"3", "Alex", "Damsted", "Midfielder", "Kiwi street, New Zeeland"},
        {"4", "Roxana", "Ion", "Central", "Somewhere else"},
        {"5", "Nikolaj", "Morup", "Center-Back", "Somewhere but not at school :( "}
            };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(vector[i, 0] + " " + vector[i, 1] + " " + vector[i, 2] + " " + vector[i, 3] + " " + vector[i, 4]);
            }
        }

        public static string searchList()
        {
            return "Not ready!";
        }

        public static void searchList(int c)
        {
            string[,] vector = new string[6, 5]
            {
        {"Id", "Firstname", "Lastname", "Position", "Adress"},
        {"1", "David", "Bertus", "Attacker", "Somewhere near school"},
        {"2", "Alexandru", "Cehan", "Goalkeeper", "Not that close to school"},
        {"3", "Alex", "Damsted", "Midfielder", "Kiwi street, New Zeeland"},
        {"4", "Roxana", "Ion", "Central", "Somewhere else"},
        {"5", "Nikolaj", "Morup", "Center-Back", "Somewhere but not at school :( "}
            };


            Console.WriteLine("1.Firstname");
            Console.WriteLine("2.Lastname");
            Console.WriteLine("3.Adress");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Please insert new firstname:");
                    vector[c, n] = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please insert new lastname:");
                    vector[c, n] = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please insert new position:");
                    vector[c, n] = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Please insert new adress:");
                    vector[c, n] = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Unknown operation!");
                    break;

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine(vector[i, 0] + " " + vector[i, 1] + " " + vector[i, 2] + " " + vector[i, 3] + " " + vector[i, 4]);
                    }




            }
        }

        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please insert the desired function:");
            string ask = Console.ReadLine();
            switch (ask)
            {
                case "list":
                    showList();
                    break;
                case "edit":
                    Console.WriteLine("Please choose what you want to edit:");
                    number = int.Parse(Console.ReadLine());
                    searchList(number);
                    break;
                case "delete":
                    Console.WriteLine("Not ready!");
                    break;
                default:
                    Console.WriteLine("Unknown operation!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
