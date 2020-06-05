using CircusTrainlib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrainlib
{
    public class Wagon
    {
        
        private List<Animal> _animals = new List<Animal>();
        public int Capacity { get
            {

                int sum = 0;

                foreach (Animal animal in _animals)
                {
                    sum += (int) animal.AnimalSize;   
                }

                return 10 - sum;
                } 
            }

        public bool AddAnimal(Animal animal)
        {

            if (!AnimalFit(animal))
            {
                return false;
            }

            foreach (Animal animalInWagon in _animals)
            {
                if(animalInWagon.AnimalType == Animal.animalType.carnivore && animalInWagon.AnimalSize >= animal.AnimalSize)
                {
                    return false;
                }

                if (animal.AnimalType == Animal.animalType.carnivore && animal.AnimalSize >= animalInWagon.AnimalSize)
                {
                    return false;
                }
            }

            _animals.Add(animal);
            return true;

        }

        private bool AnimalFit(Animal animal)
        {

            if ((int)animal.AnimalSize <= Capacity)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Wagon: " + string.Join(", ", _animals);
        }

    }
}
