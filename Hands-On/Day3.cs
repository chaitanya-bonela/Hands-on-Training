using System;
using System.Xml.Linq;

public class Day3
{
    public abstract class Animal
    {
        private string Name;
        public  SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public static void Main()
    {
        Dog dog = new Dog();
        dog.SetName(Console.ReadLine());
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
}
