using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class DisplayFarmReport {
        public static void ShowStatus (Farm farm) {
            Console.WriteLine ("The Farm Report");
            
            farm.GrazingFields.ForEach(field => Console.WriteLine(field));
            farm.ChickenHouses.ForEach(house => Console.WriteLine(house));
            farm.DuckHouses.ForEach(house => Console.WriteLine(house));
        }
    }
}
