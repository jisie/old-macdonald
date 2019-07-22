using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IFacility<T>
    {
        double Capacity { get; }

        double Availability { get; }

        double AnimalCount { get; }

        void AddResource (T resource);
        void AddResource (List<T> resources);
    }
}
