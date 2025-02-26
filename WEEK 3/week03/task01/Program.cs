using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           clockType emptytime = new clockType();
            Console.WriteLine("Empty Time Is :");
            emptytime.printtime();

            Console.WriteLine(" ");
            clockType hours = new clockType(7);
            Console.WriteLine("The Time In Hours :");
            hours.printtime();
            Console.WriteLine(" ");
            clockType hoursminutes = new clockType(5,45);
            Console.WriteLine("The Time In Minutes And Hours Is :");
            hoursminutes.printtime();
            Console.WriteLine(" ");
            clockType hoursminutesseconds = new clockType(8,45,33);
            Console.WriteLine("The Time In Hours,Minutes And Seconds Is :");
            hoursminutesseconds.printtime();
            Console.WriteLine(" ");
            hoursminutesseconds.incrementhour();
            Console.WriteLine("Time With Incremented Hours : ");
            hoursminutesseconds.printtime();
            Console.WriteLine(" ");
            hoursminutesseconds.incrementminute();
            Console.WriteLine("Time With Incremented Minutes : ");
            hoursminutesseconds.printtime();
            Console.WriteLine(" ");
            hoursminutesseconds.incrementsecond();
            Console.WriteLine("Time With Incremented Seonds : ");
            hoursminutesseconds.printtime();
            bool check = hoursminutesseconds.isEqual(5, 45, 32);
            Console.WriteLine("Flag" +" " + check);
            Console.WriteLine(" ");

            clockType newtime = new clockType(10,13,45);
             check = hoursminutesseconds.isequal(newtime);
            Console.WriteLine("Object Flag" + " "+check);
            Console.WriteLine(" ");


        }
    }
}
