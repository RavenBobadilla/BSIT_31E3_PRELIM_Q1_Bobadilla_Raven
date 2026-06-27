using System;

public class Airplane : Vehicle, IFlyable
{
    public override string Name => "Airplane";

    public void Fly()
    {
        Console.WriteLine("Airplane is flying.");
    }
}