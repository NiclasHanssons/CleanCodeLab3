using HouseF.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class HouseFactory
    {
        private Dictionary<string, Type> _houses;

        public HouseFactory()
        {
            _houses = LoadHouseByReflektion();
        }

        public House BuildHouse(string houseName)
        {
            return GetHouseTypeFromDictionary(houseName.ToLower());
        }

        private Dictionary<string, Type> LoadHouseByReflektion()
        {
            IEnumerable<Type> availableHousesTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(typeof(House)));
            
            Dictionary<string, Type> availableHouses = new Dictionary<string, Type>();

            foreach (Type t in availableHousesTypes)
            {
                availableHouses.Add(t.Name.ToLower(), t);
            }

            return availableHouses;
        }

        private House GetHouseTypeFromDictionary(string houseName)
        {
            Type houseType = _houses[houseName];
            if (houseType == null)
            {
                throw new ArgumentException($"House type {houseName} is not yet avalible.");
            }
            return (House)Activator.CreateInstance(houseType);
        }
    }
}
