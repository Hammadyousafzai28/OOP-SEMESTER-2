using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bicycle and MountainBike Demo");
        Console.WriteLine("------------------------------\n");

        // Create a regular bicycle
        Console.WriteLine("Creating a regular bicycle:");
        Console.Write("Enter cadence (RPM): ");
        int cadence = int.Parse(Console.ReadLine());
        Console.Write("Enter speed (mph): ");
        int speed = int.Parse(Console.ReadLine());
        Console.Write("Enter gear: ");
        int gear = int.Parse(Console.ReadLine());

        Bicycle myBike = new Bicycle(cadence, speed, gear);
        myBike.DisplayStatus();

        // Test bicycle methods
        Console.Write("\nEnter new cadence: ");
        myBike.SetCadence(int.Parse(Console.ReadLine()));

        Console.Write("Enter gear change: ");
        myBike.SetGear(int.Parse(Console.ReadLine()));

        Console.Write("Enter speed increment: ");
        myBike.SpeedUp(int.Parse(Console.ReadLine()));

        Console.Write("Enter brake decrement: ");
        myBike.ApplyBrake(int.Parse(Console.ReadLine()));

        myBike.DisplayStatus();

        // Create a mountain bike
        Console.WriteLine("\nCreating a mountain bike:");
        Console.Write("Enter seat height (inches): ");
        int seatHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter cadence (RPM): ");
        cadence = int.Parse(Console.ReadLine());
        Console.Write("Enter speed (mph): ");
        speed = int.Parse(Console.ReadLine());
        Console.Write("Enter gear: ");
        gear = int.Parse(Console.ReadLine());

        MountainBike myMountainBike = new MountainBike(seatHeight, cadence, speed, gear);
        myMountainBike.DisplayStatus();

        // Test mountain bike methods
        Console.Write("\nEnter new seat height: ");
        myMountainBike.SetSeatHeight(int.Parse(Console.ReadLine()));

        Console.Write("Enter new cadence: ");
        myMountainBike.SetCadence(int.Parse(Console.ReadLine()));

        Console.Write("Enter speed increment: ");
        myMountainBike.SpeedUp(int.Parse(Console.ReadLine()));

        myMountainBike.DisplayStatus();
    }
}