using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
            Console.WriteLine("Grazing Field created successfully!");
            Console.WriteLine(GrazingFields[GrazingFields.Count - 1]);
        }

        public void AddChickenHouse (ChickenHouse house)
        {
            ChickenHouses.Add(house);
            Console.WriteLine("Chicken House created successfully!");
            Console.WriteLine(ChickenHouses[ChickenHouses.Count - 1]);
        }

        public void AddDuckHouse (DuckHouse house)
        {
            DuckHouses.Add(house);
            Console.WriteLine("Duck House created successfully!");
            Console.WriteLine(DuckHouses[DuckHouses.Count - 1]);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            return report.ToString();
        }
    }
}
