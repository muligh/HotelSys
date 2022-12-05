using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HotelSys
{
    internal class Program
    {
        public static void ClearLine(int lines = 15)
        {
            for (int i = 1; i <= lines; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
        static void Main(string[] args)
        {
            int[] roomPrice = new int[50] { 1125, 750, 800, 925, 500, 870, 400, 2210, 850, 940, 
                1250, 1300,2000, 650, 3000, 3250, 980, 785, 895, 2050, 840, 790, 1150, 5000,600, 
                980, 4030, 4300, 5000, 3380, 3390, 4390, 1000, 2000, 2250,2500, 3500, 1500, 1700, 
                1800, 3800, 2800, 2500, 3250, 4500, 2100, 2200, 2100, 4400, 3900};
            
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|-------------------------------------------------------------------|");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|-------------------------------------------------------------------|");
            Start:
            Console.SetCursorPosition(17, 1);
            Console.Write("MULIG HOTEL RESERVATION");
            Console.SetCursorPosition(1, 5);
            Console.Write("Enter The Number Corresponding the Service You Want To Use\n" +
                          "|1. Reserve a Room\n" +
                          "|2. Check Service Prices\n");
            Console.SetCursorPosition(1,16);
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.SetCursorPosition(0, 19);
                    ClearLine();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------|");
                    Console.SetCursorPosition(1, 5);
                    Console.Write("Enter your name: ");
                    string reserveName = Console.ReadLine();
                    Console.SetCursorPosition(1, 6);
                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 7);
                    Console.Write("Enter your Contact Number: ");
                    string contactNum = Console.ReadLine();
                    Console.SetCursorPosition(1, 8);
                    Console.Write("Enter the number of room to reserve(Room 1-50): ");
                    int roomNum = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 9);
                    Console.Write("Enter number of days to reserve: ");
                    int reserveDays = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(0, 19);
                    ClearLine();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------|");
                    Console.SetCursorPosition(1, 5);
                    Console.Write("Hi " + reserveName + "!\n" +
                                  "|You have selected Room " + roomNum + " to reserve for " + reserveDays + ".\n" +
                                  "|The total cost of your reservation" +
                                  "|Is this correct?");
                    Console.ReadLine();
                    Console.SetCursorPosition(0, 19);
                    ClearLine();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------|");
                    Console.ReadLine();
                    goto Start;
                case 2:
                    Console.SetCursorPosition(0, 19);
                    ClearLine();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|-------------------------------------------------------------------|");
                    break;
                
            }

            Console.ReadKey();
        }
    }

}
