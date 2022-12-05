using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
                    Form:
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
                    Console.Write("Enter your Contact Number: ");
                    string contactNum = Console.ReadLine();
                    Console.SetCursorPosition(1, 8);
                    Console.Write("Enter the number of room to reserve(1-50): ");
                    int roomNum = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 9);
                    Console.Write("Enter number of days to reserve: ");
                    int reserveDays = Convert.ToInt32(Console.ReadLine());
                    int costAmount = roomPrice[roomNum - 1] * reserveDays;
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
                                  "|The total cost of your reservation is " + costAmount + ".\n" +
                                  "|Enter the amount to be received for payment: ");
                    int amountPay = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(1, 9);
                    Console.Write("Your change is exactly " + (amountPay - costAmount) + ".\n" +
                                  "|To continue, type 'Proceed'\n" +
                                  "|To return to form, type 'return'\n" +
                                  "|");
                    string confirm = Console.ReadLine();
                    if (confirm == "Proceed")
                    {
                        goto Proceed;
                    }
                    else if (confirm == "Return")
                    {
                        Console.SetCursorPosition(0, 19);
                        ClearLine();
                        goto Form;
                    }
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
                    Console.SetCursorPosition(1, 5);
                    Proceed:
                    Console.Write("Congratulations!\n" +
                                  "|You have successfully reserved a room.\n" +
                                  "|Press Enter to go back to Menu.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, 19);
                    ClearLine();
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
                    goto Start;
                
            }

            Console.ReadKey();
        }
    }

}
