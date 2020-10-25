using System;

namespace Part1 {
    class Program {
        static void Main(string[] args) {

            Odometer trip1 = new Odometer();

            trip1.SetMiles(50);
            trip1.SetFuelUsed(10);

            trip1.AddValues(10, 10);

            Console.WriteLine(trip1.GetMiles());
            Console.WriteLine(trip1.GetFuelUsed());

            Console.WriteLine(trip1.MilesPerGallon());

            trip1.Reset();
            Console.WriteLine(trip1.ToString());

            Odometer trip2 = new Odometer(100, 25);
            Console.WriteLine(trip2);
            Console.WriteLine(trip2.MilesPerGallon());

            Odometer trip3 = new Odometer(100, 25);

            Console.WriteLine(trip1.Equals(trip2));
            Console.WriteLine(trip2.Equals(trip3));

        }
    }
}
