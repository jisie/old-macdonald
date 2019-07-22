using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<Chicken>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<Chicken> _animals = new List<Chicken>();

        public string ShortId
        {
            get
            {
                return $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}" ;
            }
        }

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public double Availability {
            get {
                return _capacity - _animals.Count;
            }
        }

        public double AnimalCount {
            get {
                return _animals.Count;
            }
        }

        public void AddResource (Chicken animal)
        {
            _animals.Add(animal);            
        }

        public void AddResource (List<Chicken> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append($"Chicken house {ShortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
