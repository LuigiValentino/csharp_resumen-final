using System;

namespace CSharpConcepts
{
    public class Animal
    {
        public string Name;
        public int Age;

        // Constructor sin parametros
        public Animal()
        {
            Name = "Sin Nombre";
            Age = 0;
        }

        // Constructor con parametros
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Animal: {Name}, Edad: {Age} años");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal("Perro", 5);

            animal1.ShowInfo();
            animal2.ShowInfo();
        }
    }
}
