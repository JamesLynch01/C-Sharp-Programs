using System;
using System.Collections.Generic;

namespace Irentstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentals = new List<IRentable>();
            rentals.Add(new boat(60));
            rentals.Add(new boat(700));
            rentals.Add(new car(7));
            rentals.Add(new car(800));
            rentals.Add(new house(90000));
            rentals.Add(new house(900));

            foreach(var items in rentals)
            {
                Console.WriteLine(items.GetDescription() +" " + items.GetDailyRate());
            }
        }

        public interface IRentable
        {
            public decimal GetDailyRate();

            public string GetDescription();
        }

        public class boat : IRentable
        {
            decimal HourlyRate;

            public boat(decimal hourlyRate)
            {
                this.HourlyRate = hourlyRate;

            }

            public decimal GetDailyRate()
            {
                return HourlyRate * 24;
            }

            public string GetDescription()
            {
                return "Boat will sink in a hour, but please don't barter down my ridulous price down.";
            }
        }

        class car : IRentable
        {
            decimal DailyRate;

            public car(decimal dailyRate)
            {
                this.DailyRate = dailyRate;
            }

            public decimal GetDailyRate()
            {
                return DailyRate;
            }

            public string GetDescription()
            {
                return "car is really crappy.";
            }

        }

        class house : IRentable
        {
            decimal WeeklyRate;

            public house (decimal weeklyRate)
            {
                this.WeeklyRate = weeklyRate;
            }

            public decimal GetDailyRate()
            {
                return WeeklyRate / 7;
            }

            public string GetDescription()
            {
                return "this house is haunted and you will likely be scaried, until the Winchester arrive";
            }
        }
    }
}
