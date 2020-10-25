using System;
using System.Collections.Generic;
using System.Text;

namespace Part1 {
    class Odometer {

        //instance variables
        private int miles;
        private double fuelUsed; //mpg

        //constructors
        public Odometer() {
            miles = 0;
            fuelUsed = 15;
        }
        public Odometer(int miles, double fuelUsed) {
            this.miles = miles;
            this.fuelUsed = fuelUsed;
        }

        /// <summary>
        /// Set miles
        /// </summary>
        /// <param name="miles">Value to set miles to</param>
        public void SetMiles(int miles) {
            this.miles = miles;
        }

        /// <summary>
        /// Get miles
        /// </summary>
        /// <returns>Value of miles</returns>
        public int GetMiles() {
            return miles;
        }

        /// <summary>
        /// Set fuelUsed
        /// </summary>
        /// <param name="fuelUsed">Value to set fuelUsed to</param>
        public void SetFuelUsed(double fuelUsed) {
            this.fuelUsed = fuelUsed;
        }

        /// <summary>
        /// Get fuelUsed
        /// </summary>
        /// <returns>Value of fuelUsed</returns>
        public double GetFuelUsed() {
            return fuelUsed;
        }

        /// <summary>
        /// Reset miles and fuelUsed
        /// </summary>
        public void Reset() {
            miles = 0;
            fuelUsed = 0;
        }

        /// <summary>
        /// Add Values to instance variables
        /// </summary>
        /// <param name="miles">miles to add</param>
        /// <param name="fuelUsed">fuel to add</param>
        public void AddValues (int miles, double fuelUsed) {
            this.miles += miles;
            this.fuelUsed += fuelUsed;
        }

        /// <summary>
        /// Calculate fuel used
        /// </summary>
        /// <returns>Fuel used</returns>
        public double MilesPerGallon() {
            return miles / (Double) fuelUsed;
        }

        /// <summary>
        /// Print values in string form
        /// </summary>
        /// <returns>Instance variables in string form</returns>
        public override string ToString() {
            return "Miles Driven: " + miles + "\nFuel Used: " + fuelUsed;
        }

        /// <summary>
        /// Check if two objects are the same
        /// </summary>
        /// <param name="odometer">Odometer object</param>
        /// <returns>True if equal</returns>
        public bool Equals(Odometer odometer) {
            return miles == odometer.miles && fuelUsed == odometer.fuelUsed;
        }

    }
}
