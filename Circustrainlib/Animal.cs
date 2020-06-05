using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrainlib
{
    public class Animal
    {
        public animalSize AnimalSize { get; private set; }
        public animalType AnimalType { get; private set; }

        public Animal(animalType t, animalSize s)
        {
            AnimalSize = s;
            AnimalType = t;
        }
        public enum animalSize
        {
            small = 1,
            medium = 3,
            large = 5
        }

        public enum animalType
        {
            carnivore,
            herbivore
        }

        public override string ToString()
        {
            return AnimalType.ToString() + " " + AnimalSize.ToString();
        }    
    }
}

    
