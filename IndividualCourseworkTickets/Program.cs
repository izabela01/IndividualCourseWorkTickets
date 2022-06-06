using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCourseworkTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ID .. in main func");
            Ticket newTick = new Ticket();
            newTick.TicketOut();

            Customer cust = new Customer();
           Customer newOne =  cust.GetLogin();
            Console.WriteLine("Welcome " + newOne.userName);

            Seat seat01 = new Seat();
            seat01.addToTheFloorPlan();

        }
    }
}
