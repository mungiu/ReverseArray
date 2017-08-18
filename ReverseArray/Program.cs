using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            ////static method, does not create new array, works in place
            //Array.Reverse(daysOfWeek);

            //LINQ method does not reverse in place
            //returns a new collection (not necessarely an array)
            var reversed = daysOfWeek.Reverse().ToArray();

            foreach (string day in reversed)
                Console.WriteLine(day);
        }
    }
}
