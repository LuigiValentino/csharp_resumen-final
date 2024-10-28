using System;

namespace CSharpConcepts
{
    public class MethodsExample
    {
        // Metodo simple sin retorno ni parametros
        public void PrintMessage()
        {
            Console.WriteLine("Este es un método sin retorno.");
        }

        // Metodo con parametros y retorno
        public int Add(int a, int b)
        {
            return a + b; // Retorna la suma de 'a' y 'b'
        }

        // Metodo sobrecargado
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void Display(string message, int number)
        {
            Console.WriteLine($"{message} {number}");
        }

        public static void Main(string[] args)
        {
            MethodsExample example = new MethodsExample();
            example.PrintMessage();
            Console.WriteLine("Suma: " + example.Add(3, 4));
            example.Display("Hola");
            example.Display("Número", 10);
        }
    }
}
