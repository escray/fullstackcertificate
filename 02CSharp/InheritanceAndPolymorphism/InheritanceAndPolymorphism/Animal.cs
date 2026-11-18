using System;
using System.Net;

namespace InheritanceAndPolymorphism;

public interface IAnimal
{
    public void Eat()
    {

    }
}

public class Animal
{
    public virtual void MakeSound()
    {
        System.Console.WriteLine("Noise");
    }
}

public class Dog : Animal, IAnimal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Bark");
    }
    public void Eat()
    {
        System.Console.WriteLine("Eat meat and bone.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        System.Console.WriteLine("Meow");
    }

    public void Eat()
    {
        System.Console.WriteLine("Eat fish.");
    }
}
