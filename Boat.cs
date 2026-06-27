using System;

public class Boat : Vehicle, ISailable
{
    public override string Name => "Boat";

    public void Sail()
    {
        Console.WriteLine("Boat is sailing.");
    }
}