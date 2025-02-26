using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWeek3.BL
{
     class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h,int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;

        }
        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementminutes()
        {
            minutes++;
        }

        public void incrementHour()
        {
            hours++;
        }

        public void printTime()
        {
            Console.WriteLine(hours + "  "+ minutes +"  " + seconds);
        }
       
        public bool isEqual ( int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds ==s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            clockType empty_time = new clockType();
            Console.Write("Empty time: ");
            empty_time.printTime();

            clockType hour_time= new clockType(8);
            Console.Write("hour time: ");
            hour_time.printTime();

            clockType minute_time = new clockType(8,10);
            Console.Write("minutes time; ");
            minute_time.printTime();

            clockType full_time= new clockType(8,10,10);
            Console.Write("Full time: ");
            full_time.printTime();

            full_time.incrementSecond();
            Console.Write("Full time (increment second): ");
            full_time.printTime();

        }



    }
   
    
}
