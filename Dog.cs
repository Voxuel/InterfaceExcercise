using System;

namespace InterfaceExcercise
{
    public class Dog : IAnimal, IAnimal2
    {
         void IAnimal.AnimalEating()
        {
            Console.WriteLine("The Dog is eating");
        }

         void IAnimal2.AnimalEating()
         {
             Console.WriteLine("Eating from dog nr 2");
         }
    }
}