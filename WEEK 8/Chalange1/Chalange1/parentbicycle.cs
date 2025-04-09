using System;

public class Bicycle
{
    // Fields
    private int cadence;
    private int gear;
    private int speed;

    // Constructor
    public Bicycle(int cadence, int speed, int gear)
    {
        this.cadence = cadence;
        this.speed = speed;
        this.gear = gear;
    }

    // Methods
    public void SetCadence(int newCadence)
    {
        cadence = newCadence;
        Console.WriteLine($"Cadence set to: {cadence}");
    }

    public void SetGear(int newGear)
    {
        gear = newGear;
        Console.WriteLine($"Gear set to: {gear}");
    }

    public void ApplyBrake(int decrement)
    {
        speed -= decrement;
        if (speed < 0) speed = 0;
        Console.WriteLine($"Speed decreased by {decrement}. Current speed: {speed}");
    }

    public void SpeedUp(int increment)
    {
        speed += increment;
        Console.WriteLine($"Speed increased by {increment}. Current speed: {speed}");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"\nBicycle Status:");
        Console.WriteLine($"Cadence: {cadence}");
        Console.WriteLine($"Gear: {gear}");
        Console.WriteLine($"Speed: {speed}");
    }
}