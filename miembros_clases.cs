using System;

namespace CSharpConcepts
{
    public class Car
    {
        // Miembro de clase
        public string Model;
        public int Year;

        // Miembro constante
        public const string Type = "Automóvil";

        // Miembro estatico
        public static int TotalCars;

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
            TotalCars++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Modelo: {Model}, Año: {Year}, Tipo: {Type}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", 2020);
            car1.ShowInfo();
            Console.WriteLine("Total de autos: " + Car.TotalCars);
        }
    }
}
