using System;

namespace CSharpConcepts
{
    public class Book
    {
        // Campo privado
        private string title;

        // Propiedad con get y set
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public void DisplayTitle()
        {
            Console.WriteLine("Título del libro: " + Title);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "C# para Principiantes";
            book.DisplayTitle();
        }
    }
}
