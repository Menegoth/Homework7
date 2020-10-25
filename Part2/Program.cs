using System;

namespace Part2 {
    class Program {
        static void Main(string[] args) {

            //testing all contructors and to string
            Temperature temp1 = new Temperature();
            Console.WriteLine(temp1);
            Temperature temp2 = new Temperature(212, 'f');
            Console.WriteLine(temp2.ToString());
            Temperature temp3 = new Temperature(40);
            Console.WriteLine(temp3);
            Temperature temp4 = new Temperature('f');
            Console.WriteLine(temp4.ToString());

            //test set methods
            temp1.SetTemperature(100);
            temp3.SetScale('f');
            temp4.SetTemperatureScale(78, 'c');

            //test both get methods
            Console.WriteLine(temp1.GetTemperatureFarenheit());
            Console.WriteLine(temp2.GetTemperatureCelsius());
            Console.WriteLine(temp3.GetTemperatureFarenheit());
            Console.WriteLine(temp4.GetTemperatureCelsius());

            //test equals method
            Console.WriteLine(temp1.Equals(temp2));
            Console.WriteLine(temp3.Equals(temp4));

        }
    }
}
