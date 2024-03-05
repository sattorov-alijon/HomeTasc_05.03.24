namespace Task1;

public class Car : IVehicle
{
    public int Petrol { get; set; }
    public void Drive()
    {
        if (Petrol>0)            
        System.Console.WriteLine("Driving");
    }

    public bool Refuel()
    {
        Petrol+=50;
        return true;
    }
    public Car(int petrol)
    {
        Petrol=petrol;
    }
}
