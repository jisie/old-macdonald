using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseFacility {

        // public void PurchaseResource<T> (IResource resource, int index)
        // {
        //     Console.WriteLine(typeof(T).ToString());
        //     switch (typeof(T).ToString())
        //     {
        //         case "Cow":
        //             GrazingFields[index].AddResource((IGrazing)resource);
        //             break;
        //         default:
        //             break;
        //     }
        // }
        public static void CollectInput<T> (Farm farm, IResource resource) {
            // Console.Clear();


            List<dynamic> FarmFacilities = new List<dynamic>();

            Console.WriteLine(typeof(T).ToString());
            // switch(typeof(T).ToString()) 
            // {
            //     case "Cow":
            //         FarmFacilities = farm.GrazingFields;
            //         break;

            //     case "Chicken":
            //         FarmFacilities = farm.ChickenHouses;
            //         break;
            // }

            Console.WriteLine ("List of facilities: ");

            for (int i = 0; i < FarmFacilities.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Grazing Field");
            }

            // // How can I output the type of animal chosen here?
            // Console.WriteLine ($"Place the animal where?");

            // Console.Write ("> ");
            // int choice = Int32.Parse(Console.ReadLine ()) - 1;

            // farm.GrazingFields[choice].AddResource(animal);
            // Console.WriteLine(farm.GrazingFields[choice]);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}
