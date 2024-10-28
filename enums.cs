using System;

namespace CSharpConcepts
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Days today = Days.Friday;
            Console.WriteLine("Hoy es: " + today);
        }
    }
}
