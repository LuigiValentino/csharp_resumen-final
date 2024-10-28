using System;

namespace CSharpConcepts
{
    // Clase base
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("El animal está comiendo.");
        }
    }

    // Clase derivada
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("El perro está ladrando.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}
