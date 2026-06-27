using System;

public class Car : Vehicle, IDriveable
{
    public override string Name => "Car";

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}