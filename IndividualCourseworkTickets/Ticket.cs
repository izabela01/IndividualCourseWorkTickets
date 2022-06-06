using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCourseworkTickets
{
    internal class Ticket
    {
        TicketType ticketType;

        public enum TicketType
        {
            Senior_Citizen = 15,
            Adult = 20,
            Student = 18,
            Child = 12,
        }

        public void TicketOut()
        {
            Console.WriteLine("The ticket type ..", TicketType.Adult);
        }

    }


   
}
