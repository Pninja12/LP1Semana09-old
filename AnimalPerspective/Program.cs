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
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public int NumberOfNipples { get { return 4; } }
    }
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }

        public int NumberOfNipples { get { return 6; } }
    }
    public class Bat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Chirp";
        }

        public int NumberOfNipples { get { return 2; } }
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
