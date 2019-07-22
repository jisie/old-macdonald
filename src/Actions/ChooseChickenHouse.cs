using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse {
        public static void CollectInput (Farm farm, Chicken chicken) {
            // Console.Clear();

            Console.WriteLine ("List of chicken houses: ");

            List<ChickenHouse> AvailableChickenHouses = farm.ChickenHouses.Where(field => field.Availability > 0).ToList();

            for (int i = 0; i < AvailableChickenHouses.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Chicken House ({AvailableChickenHouses[i].ShortId}), currently contains {AvailableChickenHouses[i].AnimalCount} chickens.");
            }

            Console.WriteLine ();

            // How can I output the type of chicken chosen here?
            Console.WriteLine ($"Place the chicken where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ()) - 1;

            AvailableChickenHouses[choice].AddResource(chicken);
            Console.WriteLine(AvailableChickenHouses[choice]);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(chicken, choice);

        }
    }
}
