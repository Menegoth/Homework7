using System;
using System.Collections.Generic;
using System.Text;

namespace Part2 {
    class Temperature {

        //instance variables
        private double temperature = 0.0;
        private char scale = 'c';

        //constructors
        public Temperature () { }
        public Temperature (float temperature) {
            this.temperature = temperature;
        }
        public Temperature (char scale) {
            this.scale = scale;
        }
        public Temperature (float temperature, char scale) {
            this.temperature = temperature;
            this.scale = scale;
        }

        /// <summary>
        /// Get temperature in celsius
        /// </summary>
        /// <returns>Celsius temperature rounded to one decimal</returns>
        public double GetTemperatureCelsius() {

            //check whether scale is c or f
            if (scale == 'c') {
                return temperature;
            } else {
                return Math.Round((temperature - 32.0) * (5.0 / 9), 1);
            }

        }

        /// <summary>
        /// Get temperature in farenheit
        /// </summary>
        /// <returns>Farenheit temperature rounded to one decimal</returns>
        public double GetTemperatureFarenheit() {

            //check if c or f
            if (scale == 'f') {
                return temperature;
            } else {
                return Math.Round((temperature * (9/5.0) + 32), 1);
            }

        }

        /// <summary>
        /// set temperature
        /// </summary>
        /// <param name="temperature">temperature value</param>
        public void SetTemperature(float temperature) {
            this.temperature = temperature;
        }

        /// <summary>
        /// set scale
        /// </summary>
        /// <param name="scale">scale value</param>
        public void SetScale(char scale) {
            this.scale = scale;
        }

        public void SetTemperatureScale(float temperature, char scale) {
            this.temperature = temperature;
            this.scale = scale;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>returns object in string format</returns>
        public override string ToString() {
            return "Temperature: " + temperature + "\nScale: " + scale;
        }

        /// <summary>
        /// Compare two temperatures
        /// </summary>
        /// <param name="e">Second temperature object</param>
        /// <returns>boolean</returns>
        public bool Equals(Temperature e) {

            return GetTemperatureCelsius() == e.GetTemperatureCelsius();

        }

    }
}
