using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class StudentHouse : House
    {
        public StudentHouse()
        {
            NoOfRooms = 1;
            NoOfWindows = 1;
            StreetAdress = "Studentbacken 2B";
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 0;
        }
    }
}
