using InheritanceAndPolymorphism;

public class Program
{
    static void Main(string[] args)
    {

        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.MakeSound();
        dog.Eat();
        cat.MakeSound();
        cat.Eat();

        List<Animal> animals = new List<Animal>();
        animals.Add(dog);
        animals.Add(cat);

        foreach (var item in animals)
        {
            item.MakeSound();

        }
    }
}
