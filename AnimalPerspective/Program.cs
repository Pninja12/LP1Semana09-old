using System;

namespace AnimalPerspective
{
    public class Animal
    {
        public virtual string Sound()
        {
            return ": ";
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
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Chirp";
        }

        public int NumberOfNipples { get { return 2; } }

        public int NumberOfWings { get { return 2; } }
    }
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }

        public int NumberOfWings { get { return 2; } }
    }

    public interface IMammal
    {
        int NumberOfNipples {get; }
    }

    public interface ICanFly
    {
        int NumberOfWings {get; }
    }
    class Program
    {
        private static void Main()
        {
            Animal[] animalsarray = new Animal[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                animalsarray[i] = random.Next(0, 3) switch
                {
                    0 => new Bat(),
                    1 => new Bee(),
                    2 => new Cat(),
                    3 => new Dog()
                };
            }

            foreach (Animal animal in animalsarray)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
                Console.Write($"{animal.GetType().Name} says");
                Console.WriteLine($"{animal.Sound()}");
                if (animal is IMammal)
                {
                    Console.WriteLine($"Nº of Nipples = {(animal as IMammal).NumberOfNipples}");
                }
                if (animal is ICanFly)
                {
                    Console.WriteLine($"Nº of Wings = {(animal as ICanFly).NumberOfWings}");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
            }

            /* const int n = 10;
            Animal[] animals = new Animal[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                animals[i] = rnd.Next(4) switch
                {
                    0 => new Bat(),
                    1 => new Bee(),
                    2 => new Cat(),
                    3 => new Dog(),
                    _ => throw new ArgumentOutOfRangeException("Unknown animal!")
                };
            }

            foreach (Animal a in animals)
            {
                Console.Write($"{a.GetType().Name} says ");
                Console.Write(a.Sound());
                if (a is IMammal)
                    Console.Write($", No.Nipples = {(a as IMammal).NumberOfNipples}");
                if (a is ICanFly)
                    Console.Write($", No.Wings = {(a as ICanFly).NumberOfWings}");
                Console.WriteLine();
            } */
        }
    }
}
