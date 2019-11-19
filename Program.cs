using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();
            Building East = new Building("500 Fatherland")
            {
                Width = 2_000,
                Height = 4_000,
                Stories = 23
            };
            Building West = new Building("512 8th Avenue")
            {
                Width = 2_500,
                Height = 4_500,
                Stories = 31
            };
            Building South = new Building("232 Ash Drive")
            {
                Width = 1_000,
                Height = 2_730,
                Stories = 13
            };
            Building North = new Building("1212 Charlotte Avenue")
            {
                Width = 1_020,
                Height = 2_980,
                Stories = 19
            };
            North.Construct();
            South.Construct();
            East.Construct();
            West.Construct();
            North.Purchase("BBQ shop");
            South.Purchase("Barber shop");
            East.Purchase("A Bar");
            West.Purchase("Another Bar");

            City Philville = new City("Nashville", "Phil Griswold", 2001);
            Philville.buildingCollection.Add(North);
            Philville.buildingCollection.Add(South);
            Philville.buildingCollection.Add(West);
            Philville.buildingCollection.Add(East);

            foreach (Building building in Philville.buildingCollection)
            {
                Console.WriteLine(building.Description);
            }
        }
    }
}