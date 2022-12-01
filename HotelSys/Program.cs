using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace HotelSys
{
    internal class Program
    {
        public static void ClearLine(int lines = 1)
        {
            for (int i = 1; i <= lines; i++)
            {
                lines = 15;
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
        static void Main(string[] args)
        {
            
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
            Console.SetCursorPosition(17, 1);
            Console.Write("MULIG HOTEL RESERVATION");
            Console.SetCursorPosition(1, 5);
            Console.Write("Enter The Number Corresponding the Service You Want To Use\n" +
                          "|1. Reserve a Room\n" +
                          "|2. Check Reservation\n" +
                          "|3. Check Service Prices\n" +
                          "|4. Cancel Reservation" );
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
                    break;
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
                case 3:
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
                case 4:
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
