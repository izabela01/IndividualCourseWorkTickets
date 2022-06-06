using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCourseworkTickets
{
    internal class Seat
    {
        // how do I declare this as a multidimensional array 
        int[][] floorPlan;
        int rowPosition;
        int columnPosition;
        char SeatStatus; 

        public Seat()
        {
            this.floorPlan = [9][6];
            this.rowPosition = 0;
            this.columnPosition = 0;
        }

    public void addToTheFloorPlan()
        {
            
            for(int i = 0; i < 10; i++)
            {
                for(int r =0; r < 7; r++)
                {
                    this.floorPlan[i][r] = 'A';
                }
            }
            Console.WriteLine("floorPlan = > ", floorPlan);
        }


    }
}
