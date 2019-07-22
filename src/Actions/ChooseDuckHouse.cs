using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseDuckHouse {
        public static void CollectInput (Farm farm, Duck duck) {
            // Console.Clear();

            Console.WriteLine ("List of duck houses: ");

            List<DuckHouse> AvailableDuckHouses = farm.DuckHouses.Where(field => field.Availability > 0).ToList();

            for (int i = 0; i < AvailableDuckHouses.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Duck House ({AvailableDuckHouses[i].ShortId}), currently contains {AvailableDuckHouses[i].AnimalCount} ducks");
            }

            Console.WriteLine ();

            // How can I output the type of duck chosen here?
            Console.WriteLine ($"Place the duck where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ()) - 1;

            AvailableDuckHouses[choice].AddResource(duck);
            Console.WriteLine(AvailableDuckHouses[choice]);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(duck, choice);

        }
    }
}
