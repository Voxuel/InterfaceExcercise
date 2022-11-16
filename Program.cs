using System;

namespace InterfaceExcercise
{
    class Program
    {
        static void Main(string[] args)
        {


            IAnimal cat = new Cat();
            IAnimal2 cat2 = new Cat();

            IAnimal dog = new Dog();
            IAnimal2 dog2 = new Dog();
            
            
            cat.AnimalEating();
            cat2.AnimalEating();
            dog.AnimalEating();
            dog2.AnimalEating();


            Console.ReadLine();
        }
    }
}