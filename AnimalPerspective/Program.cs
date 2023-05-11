using System;

namespace AnimalPerspective
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Sound will be ";
        }
    }
    public class Cat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
    public class Dog : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Chirp";
        }
    }
    public class Bee : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }
    }

    public interface IMammal
    {
        int NumberOfNipples {get; }
        void Burn ( ) ;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
