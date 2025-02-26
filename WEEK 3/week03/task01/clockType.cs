using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    public class clockType
    {
        int hours;
        int minutes;
        int seconds;
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
       
        public clockType(int h ,int m, int s)
        {
            hours = h;
            minutes = m;
           seconds = s;
        } 
        public void incrementsecond()
        {
            seconds++;
        }
        public void incrementminute()
        { 
           minutes++;
        }
        public void incrementhour()
        {
            hours++;
        }
        public void printtime()
        {
            Console.WriteLine(hours + " "+minutes+ " "+" "+seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            return false;
        }
         public bool isequal(clockType temp)
        {
            if(temp.hours==hours&&temp.minutes==minutes&&temp.seconds==seconds)
            {
                return true;
            }
            return false;
        }
        
    }
}
