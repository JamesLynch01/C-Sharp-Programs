using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Scrapyard = new CarLot("Scrapyard", new List<Vehicle>());
            CarLot Discountwheels = new CarLot("Discount Wheels", new List<Vehicle>());
            Car RedOne = new Car("aos4848oad", "pretty", "strong", 7.00, "Toyota", 8);
            Truck AlsoRedOne = new Truck("0iw3piubfqpibu", "tough", "weak", 9.00, "Queen");
            Scrapyard.AddVehicle(RedOne);
            Discountwheels.AddVehicle(AlsoRedOne);
            Scrapyard.PrintInfo();
            Discountwheels.PrintInfo();
        }

        class CarLot
        {
            string NameCarLot;
            public List<Vehicle> Vehicles = new List<Vehicle>();
            public CarLot(string nameCart, List<Vehicle>Vehicles)
            {
                this.NameCarLot = nameCart;
                this.Vehicles = Vehicles;
            }            
           
            public void AddVehicle(Vehicle autoCars)
            {
                Vehicles.Add(autoCars);
            }

            public List<Vehicle> GetVehicles()
            {
                return Vehicles;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"{NameCarLot} has {Vehicles.Count} items for sell");
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine(vehicle.AutoInfo());
                }
            }
        }

        public abstract class Vehicle
        {
            public string License { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public double Price { get; set; }

            public Vehicle(string license, string make, string model, double price )
            {
                this.License = license;
                this.Make = make;
                this.Model = model;
                this.Price = price;
            }

            public virtual string AutoInfo()
            {
                return $"\n Bubba, you did it wrong";
            }
        }

        public class Car : Vehicle
        {
            public string Type { get; set; }
            public int DoorNumbers { get; set; }

            public Car(string license, string make, string model, double price, string type, int doorNumbers) : base (license, make, model, price)
            {
                this.Type = type;
                this.DoorNumbers = doorNumbers;
                this.License = license;
                this.Make = make;
                this.Model = model;
                this.Price = price;

            }

            public override string AutoInfo()
            {
                return $"this Car has the following information {Type}, {DoorNumbers}, {License}, {Make}, {Model}, {Price}";
            }
        }

        public class Truck : Vehicle
        {
            public string BedSize { get; set; }

            public Truck(string license, string make, string model, double price, string bedSize) : base (license, make, model, price)
            {
                this.License = license;
                this.Make = make;
                this.Model = model;
                this.Price = price;
                this.BedSize = bedSize;
            }

            public override string AutoInfo()
            {
                return $"this Car has the following information {BedSize}, {License}, {Make}, {Model}, {Price}";
            }
        }
    }
}
