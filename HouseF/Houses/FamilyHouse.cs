using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class FamilyHouse : House
    {
        public FamilyHouse()
        {
            NoOfRooms = 4;
            NoOfWindows = 10;
            StreetAdress = "Familjegatan 13";
            HasSwimmingPool = false;
            ParkingSpotsInGarage = 2;
        }
    }
}
