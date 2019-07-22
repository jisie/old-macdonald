using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

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

        public void AddResource (Duck animal)
        {
            _animals.Add(animal);            
        }

        public void AddResource (List<Duck> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append($"Duck house {ShortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
