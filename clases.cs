using System;

namespace CSharpConcepts
{
    // Definicion de clase
    public class Person
    {
        // Miembros de clase: atributos
        public string Name;
        public int Age;

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Metodo de clase
        public void Greet()
        {
            Console.WriteLine($"Hola, mi nombre es {Name} y tengo {Age} años.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Carlos", 30);
            person.Greet();
        }
    }
}
