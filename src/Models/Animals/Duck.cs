using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IHousing, IEggProducing, IFeatherProducing {

        private Guid _id = Guid.NewGuid();
        private int _eggsProduced = 7;
        private double _feathersProduced = 0.5;


        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double SeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Ostrich";

        // Methods
        public void Peck () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.SeedPerDay}kg of seed");
        }

        public int Collect () {
            return _eggsProduced;
        }

        public double Pluck () {
            return _feathersProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}
