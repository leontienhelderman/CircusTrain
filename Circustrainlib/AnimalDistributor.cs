using CircusTrainlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Circustrainlib
{
    public class AnimalDistributor
    {
        private List<Wagon> _wagons = new List<Wagon>();

        public IEnumerable<Wagon> Wagons { get => _wagons; }

        public void Distribute(List<Animal> animals)
        {

            foreach(Animal a in animals)
            {
                bool added = false;
                foreach (Wagon wagon in _wagons)
                {
                    if (wagon.AddAnimal(a))
                    {
                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    Wagon w = new Wagon();
                    w.AddAnimal(a);
                    _wagons.Add(w);
                }
            }

        }
    }
}
