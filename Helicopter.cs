using System;

public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public override string Name => "Helicopter";

    public void Fly()
    {
        Console.WriteLine("Helicopter is flying.");
    }

    public void Drive()
    {
        Console.WriteLine("Helicopter is driving.");
    }
}