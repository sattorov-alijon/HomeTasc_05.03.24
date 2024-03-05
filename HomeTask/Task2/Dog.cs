namespace Task2;

public class Dog : Animal
{
    public Dog(string name)
    {
        base.SetName(name);
    }

    public override void Eat()
    {
        System.Console.WriteLine("Eating");;
    }
}
