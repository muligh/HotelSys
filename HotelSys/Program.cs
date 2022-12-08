using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
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
        static int Main(string[] args)
        {
            int n = 0;
            roomReserves[] sheme = new roomReserves[50];
            string reserveName=null, contactNum=null;
            bool isItReal=false;
            int num=0, roomNum=0, reserveDays=0;
            sheme[0] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[1] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[2] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[3] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[4] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[5] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[6] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[7] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[8] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[9] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[10] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[11] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[12] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[13] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[14] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[15] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[16] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[17] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[18] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[19] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[20] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[21] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[22] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[23] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[24] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[25] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[26] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[27] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[28] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[29] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[30] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[31] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[32] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[33] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[34] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[35] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[36] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[37] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[38] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[39] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[40] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[41] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[42] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[43] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[44] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[45] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[46] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[47] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[48] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            sheme[49] = new roomReserves(reserveName, contactNum, roomNum, reserveDays);
            int[] roomPrice = new int[50] { 1125, 750, 800, 925, 500, 870, 400, 2210, 850, 940, 
                1250, 1300,2000, 650, 3000, 3250, 980, 785, 895, 2050, 840, 790, 1150, 5000,600, 
                980, 4030, 4300, 5000, 3380, 3390, 4390, 1000, 2000, 2250,2500, 3500, 1500, 1700, 
                1800, 3800, 2800, 2500, 3250, 4500, 2100, 2200, 2100, 4400, 3900};
            while (isItReal == false)
            {
                Console.SetCursorPosition(0, 0);
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
                              "|2. Check Service Prices\n" +
                              "|3. Check Room Availability.");
                do
                {
                    Console.SetCursorPosition(1, 16);
                    try
                    {
                        isItReal = true;
                        num = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ps)
                    {
                        isItReal = false;
                        Console.SetCursorPosition(1, 15);
                        Console.WriteLine(ps.Message + "Try again.");
                    }
                } while (isItReal == false);
                switch (num)
                {
                    case 1:
                        isItReal = false;
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
                        string reservedName = Console.ReadLine();
                        Console.SetCursorPosition(1, 6);
                        Console.Write("Enter your Contact Number: ");
                        string contactNumb = Console.ReadLine();
                        Console.SetCursorPosition(1, 7);
                        Console.Write("Enter the number of room to reserve(1-50): ");
                        while (isItReal == false)
                        {
                            Console.SetCursorPosition(43, 7);
                            Console.Write("".PadRight(10));
                            Console.SetCursorPosition(43, 7);
                            bool intRoomNum = int.TryParse(Console.ReadLine(), out roomNum);
                            if (intRoomNum == true&&roomNum<51&&roomNum>0)
                            {
                                isItReal = true;
                            }
                            else
                            {
                                isItReal = false;
                                Console.Write("|Invalid.");
                            }
                        }
                        Console.SetCursorPosition(1, 8);
                        Console.Write("".PadRight(66));
                        isItReal = false;
                        Console.SetCursorPosition(1, 8);
                        Console.Write("Enter number of days to reserve: ");
                        while (isItReal == false)
                        {
                            Console.SetCursorPosition(43, 7);
                            Console.Write("".PadRight(10));
                            Console.SetCursorPosition(43, 7);
                            bool intReserveDays = int.TryParse(Console.ReadLine(), out reserveDays);
                            if (intReserveDays == true && roomNum < 51 && roomNum > 0)
                            {
                                isItReal = true;
                            }
                            else
                            {
                                isItReal = false;
                                Console.Write("|Invalid.");
                            }
                        }
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
                        Console.Write("Hi " + reservedName + "!\n" +
                                      "|You have selected Room " + roomNum + " to reserve for " + reserveDays + ".\n" +
                                      "|The total cost of your reservation is " + costAmount + ".\n" +
                                      "|Enter the amount to be received for payment: ");
                        int amountPay = Convert.ToInt32(Console.ReadLine());
                        Console.SetCursorPosition(1, 9);
                        Console.Write("Your change is exactly " + (amountPay - costAmount) + ".");
                    Try:
                        Console.Write("\n|To continue, type 'Proceed'\n" +
                                      "|To return to form, type 'return'\n" +
                                      "|");
                        string confirm = Console.ReadLine();
                        if (confirm == "Proceed"||confirm=="proceed"||confirm=="PROCEED")
                        {
                            goto Proceed;
                        }
                        else if (confirm == "Return"||confirm=="return"||confirm=="RETURN")
                        {
                            Console.SetCursorPosition(0, 19);
                            ClearLine();
                            goto Form;
                        }
                        else
                        {
                            Console.SetCursorPosition(1, 13);
                            Console.WriteLine("Invalid input. Try again.");
                            goto Try;
                        }
                    Proceed:
                        Console.Write("|Congratulations!\n" +
                                      "|You have successfully reserved a room.\n" +
                                      "|Press Enter to print your receipt.");
                        Console.ReadKey();
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
                        Console.WriteLine("Name: " + reserveName + "\n" +
                                          "|Contact Number: " + contactNum + "\n" +
                                          "|Room Number: " + roomNum + "\n" +
                                          "|Days Reserved: " + reserveDays + "\n" +
                                          "|Room Price: " + roomPrice[roomNum - 1] + "\n" +
                                          "|Amount Paid: " + costAmount + "\n" +
                                          "|Amount Given: " + amountPay + "\n");
                        sheme[n] = new roomReserves(reservedName, contactNumb, roomNum, reserveDays);
                        n++;
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 19);
                        ClearLine();
                        break;
                    case 2:
                        isItReal = false;
                        int f = 0;
                        Console.SetCursorPosition(0, 19);
                        ClearLine();
                        Console.SetCursorPosition(0, 4);
                        foreach (int j in roomPrice)
                        {
                            f++;
                            Console.WriteLine("|Room {0} = {1}\t\t\t\t\t\t\t    |", f, j);
                        }
                        Console.WriteLine("|-------------------------------------------------------------------|");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        isItReal = false;
                        Console.Clear();
                        Console.WriteLine("Room 1: " + sheme[0].checkAvailability());
                        Console.WriteLine("Room 2: " + sheme[1].checkAvailability());
                        Console.WriteLine("Room 3: " + sheme[2].checkAvailability());
                        Console.WriteLine("Room 4: " + sheme[3].checkAvailability());
                        Console.WriteLine("Room 5: " + sheme[4].checkAvailability());
                        Console.WriteLine("Room 6: " + sheme[5].checkAvailability());
                        Console.WriteLine("Room 7: " + sheme[6].checkAvailability());
                        Console.WriteLine("Room 8: " + sheme[7].checkAvailability());
                        Console.WriteLine("Room 9: " + sheme[8].checkAvailability());
                        Console.WriteLine("Room 10: " + sheme[9].checkAvailability());
                        Console.WriteLine("Room 11: " + sheme[10].checkAvailability());
                        Console.WriteLine("Room 12: " + sheme[11].checkAvailability());
                        Console.WriteLine("Room 13: " + sheme[12].checkAvailability());
                        Console.WriteLine("Room 14: " + sheme[13].checkAvailability());
                        Console.WriteLine("Room 15: " + sheme[14].checkAvailability());
                        Console.WriteLine("Room 16: " + sheme[15].checkAvailability());
                        Console.WriteLine("Room 17: " + sheme[16].checkAvailability());
                        Console.WriteLine("Room 18: " + sheme[17].checkAvailability());
                        Console.WriteLine("Room 19: " + sheme[18].checkAvailability());
                        Console.WriteLine("Room 20: " + sheme[19].checkAvailability());
                        Console.WriteLine("Room 21: " + sheme[20].checkAvailability());
                        Console.WriteLine("Room 22: " + sheme[21].checkAvailability());
                        Console.WriteLine("Room 23: " + sheme[22].checkAvailability());
                        Console.WriteLine("Room 24: " + sheme[23].checkAvailability());
                        Console.WriteLine("Room 25: " + sheme[24].checkAvailability());
                        Console.WriteLine("Room 26: " + sheme[25].checkAvailability());
                        Console.WriteLine("Room 27: " + sheme[26].checkAvailability());
                        Console.WriteLine("Room 28: " + sheme[27].checkAvailability());
                        Console.WriteLine("Room 29: " + sheme[28].checkAvailability());
                        Console.WriteLine("Room 30: " + sheme[29].checkAvailability());
                        Console.WriteLine("Room 31: " + sheme[30].checkAvailability());
                        Console.WriteLine("Room 32: " + sheme[31].checkAvailability());
                        Console.WriteLine("Room 33: " + sheme[32].checkAvailability());
                        Console.WriteLine("Room 34: " + sheme[33].checkAvailability());
                        Console.WriteLine("Room 35: " + sheme[34].checkAvailability());
                        Console.WriteLine("Room 36: " + sheme[35].checkAvailability());
                        Console.WriteLine("Room 37: " + sheme[36].checkAvailability());
                        Console.WriteLine("Room 38: " + sheme[37].checkAvailability());
                        Console.WriteLine("Room 39: " + sheme[38].checkAvailability());
                        Console.WriteLine("Room 40: " + sheme[39].checkAvailability());
                        Console.WriteLine("Room 41: " + sheme[40].checkAvailability());
                        Console.WriteLine("Room 42: " + sheme[41].checkAvailability());
                        Console.WriteLine("Room 43: " + sheme[42].checkAvailability());
                        Console.WriteLine("Room 44: " + sheme[43].checkAvailability());
                        Console.WriteLine("Room 45: " + sheme[44].checkAvailability());
                        Console.WriteLine("Room 46: " + sheme[45].checkAvailability());
                        Console.WriteLine("Room 47: " + sheme[46].checkAvailability());
                        Console.WriteLine("Room 48: " + sheme[47].checkAvailability());
                        Console.WriteLine("Room 49: " + sheme[48].checkAvailability());
                        Console.WriteLine("Room 50: " + sheme[49].checkAvailability());
                        Console.ReadKey();
                        break;
                    default:
                        isItReal = false;
                        Console.SetCursorPosition(1, 8);
                        Console.Write("Invalid input. Try again.");
                        Console.ReadKey();
                        break;
                }
            } return num;
        }
    }

}
