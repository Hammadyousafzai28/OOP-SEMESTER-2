using System;

public class MountainBike : Bicycle
{
    // Additional field
    private int seatHeight;

    // Constructor
    public MountainBike(int seatHeight, int cadence, int speed, int gear)
        : base(cadence, speed, gear)
    {
        this.seatHeight = seatHeight;
    }

    // Additional method
    public void SetSeatHeight(int newSeatHeight)
    {
        seatHeight = newSeatHeight;
        Console.WriteLine($"Seat height set to: {seatHeight}");
    }

    // Display mountain bike status
    public new void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Seat Height: {seatHeight}");
    }
}