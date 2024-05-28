using System;
namespace overriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }

    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Eat();
        }
    }
}