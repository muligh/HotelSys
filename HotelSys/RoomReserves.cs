using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSys
{
    public class roomReserves
    {
        public string nameReserve;
        public string infoContact;
        public int numRoom;
        public int daysReserve;
        public roomReserves(string nameReserve, string infoContact, int numRoom, int daysReserve)
        {
            this.nameReserve = nameReserve;
            this.infoContact = infoContact;
            this.numRoom = numRoom;
            this.daysReserve = daysReserve;
        }
        public string checkAvailability()
        {
            if (this.numRoom<51&&this.numRoom>0)
            {
                Console.WriteLine("Room: " + numRoom + ". " +
                              "Name: " + nameReserve + ". " +
                              "Contact Info: " + infoContact + ". " +
                              "Days Reserved: " + daysReserve + ".");
            }
            else
            {
                Console.WriteLine("This room is unoccupied.");
            }
            return checkAvailability();
        }

    }
}
