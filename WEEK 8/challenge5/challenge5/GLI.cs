﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace challenge5
{
    public class GLI : Car
    {
        public GLI(string model, string color, double price)
            : base(model, color, price)
        { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * 0.09;
        }

        public override void DisplayInfo(double distance)
        {
            System.Console.WriteLine($"GLI - Model: {model}, Color: {color}, Price: {price}");
            System.Console.WriteLine($"Fuel Consumption for {distance} km: {CalculateFuelConsumption(distance):F2} liters");
        }
    }

}
