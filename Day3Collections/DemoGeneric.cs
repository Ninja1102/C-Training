using System;
using System.Collections.Generic;

namespace Day3Collections
{
    class Ride
    {
        public int RideId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public decimal Fare { get; set; }

        public Ride(int id, string from, string to, decimal fare)
        {
            RideId = id;
            From = from;
            To = to;
            Fare = fare;
        }

        public override string ToString()
        {
            return $"RideId: {RideId}, From: {From}, To: {To}, Fare: {Fare}";
        }
    }

    class OLADriver
    {
        public int DriverId { get; set; }
        public string Name { get; set; }
        public string VehicleNumber { get; set; }
        public List<Ride> Rides { get; set; }

        public OLADriver(int driverId, string name, string vehicleNumber)
        {
            DriverId = driverId;
            Name = name;
            VehicleNumber = vehicleNumber;
            Rides = new List<Ride>();
        }

        public void AddRide(Ride ride)
        {
            Rides.Add(ride);
        }

        public void DisplayDriver()
        {
            Console.WriteLine($"DriverId: {DriverId}, Name: {Name}, VehicleNumber: {VehicleNumber}");
            Console.WriteLine("Rides:");
            decimal totalFare = 0;

            foreach (var ride in Rides)
            {
                Console.WriteLine(ride);
                totalFare += ride.Fare;
            }

            Console.WriteLine($"Total Fare: {totalFare}");
        }
    }

    internal class DemoGeneric
    {
        static void Main(string[] args)
        {
            Ride ride1 = new Ride(1, "Koramangala", "Indiranagar", 250);
            Ride ride2 = new Ride(2, "Indiranagar", "MG Road", 180);
            Ride ride3 = new Ride(3, "Electronic City", "Whitefield", 320);
            Ride ride4 = new Ride(4, "Airport", "City Center", 400);
            Ride ride5 = new Ride(5, "Electronic City", "Whitefield", 320);
            Ride ride6 = new Ride(6, "Thampanoor", "Kulathoor", 100);

            OLADriver driver1 = new OLADriver(101, "John Doe", "KA01AB1234");
            OLADriver driver2 = new OLADriver(102, "Jane Smith", "DL05CD5678");
            OLADriver driver3 = new OLADriver(103, "Jim Brown", "TN01XY5678");

            driver1.AddRide(ride1);
            driver1.AddRide(ride2);
            driver2.AddRide(ride3);
            driver3.AddRide(ride4);
            driver3.AddRide(ride5);
            //driver2.AddRide(ride6);

            Dictionary<int, OLADriver> drivers = new Dictionary<int, OLADriver>();
            drivers.Add(driver1.DriverId, driver1);
            drivers.Add(driver2.DriverId, driver2);
            drivers.Add(driver3.DriverId, driver3);

            foreach (var driver in drivers.Values)
            {
                driver.DisplayDriver();
                Console.WriteLine();
            }

            List<Ride> allRides = new List<Ride> { ride1, ride2, ride3, ride4, ride5, ride6 };
            Console.WriteLine("Unassigned Rides:");
            foreach (var ride in allRides)
            {
                bool assigned = false;

                foreach (var driver in drivers.Values)
                {
                    if (driver.Rides.Contains(ride))
                    {
                        assigned = true;
                        break;
                    }
                }

                if (!assigned)
                {
                    Console.WriteLine(ride);
                }
            }
        }
    }
}
