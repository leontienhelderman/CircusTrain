using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrainlib;
using CircusTrainlib;

namespace CircusTrainTests
{
    [TestClass]
    public class WagonTest
    {
        [TestMethod]
        public void WagonFullCheck()
        {
            //Arrange
            var wagon = new Wagon();

            Animal animalLarge = new Animal(Animal.animalType.herbivore, Animal.animalSize.large);
            Animal animalMedium = new Animal(Animal.animalType.herbivore, Animal.animalSize.medium);
            Animal testAnimal = new Animal(Animal.animalType.herbivore, Animal.animalSize.medium);

            //Act
            wagon.AddAnimal(animalLarge);
            wagon.AddAnimal(animalMedium);

            //Assert
            Assert.IsFalse(wagon.AddAnimal(testAnimal));
        }

        [TestMethod]
        public void CapacityCheck()
        {
            //Arrange
            var wagon = new Wagon();

            Animal testAnimal = new Animal(Animal.animalType.herbivore, Animal.animalSize.large);

            //Act
            wagon.AddAnimal(testAnimal);

            //Assert
            Assert.AreEqual(5, wagon.Capacity);
        }

        [TestMethod]
        public void AddCarnivoreCheck()
        {
            //Arrange
            var wagon = new Wagon();

            Animal carnivoreMedium = new Animal(Animal.animalType.carnivore, Animal.animalSize.medium);
            Animal testAnimal = new Animal(Animal.animalType.carnivore, Animal.animalSize.small);

            //Act
            wagon.AddAnimal(carnivoreMedium);

            //Assert
            Assert.IsFalse(wagon.AddAnimal(testAnimal));
        }
    }
}
