using System;

namespace CSharpConcepts
{
    public interface IPlayable
    {
        void Play();
    }

    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Tocando la guitarra.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IPlayable playable = new Guitar();
            playable.Play();
        }
    }
}
