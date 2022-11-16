using System;
namespace InterfaceExcercise
{
    public class Cat : IAnimal, IAnimal2
    {
         void IAnimal2.AnimalEating()
        {
            Console.WriteLine("The Cat is eating from 2");
        }

        void IAnimal.AnimalEating()
        {
            Console.WriteLine("Eating from 1 cat");
        }

    }
}