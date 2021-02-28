using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    abstract class AeroForce : Force
    {
        //http://www.grc.nasa.gov/WWW/k-12/airPLANE/atmosmet.html
        protected double topArea;
        protected double frontArea;
        protected double sideArea;

        public double caluclateDensity(double altitude)      //altitude in meters
        {
            double temprature = 0, pressure = 0, density;
            // temprature (Celsius)
            //pressure  (K-Pa) kilo-Pascals

            if (altitude < 11000) // Troposphere
            {
                temprature = 15.04 - 0.00649 * altitude;
                pressure = 101.29 * Math.Pow(((temprature + 273.1) / 288.08), 5.256);
            }
            if (altitude < 25000) // Lower srtatosphere 
            {
                temprature = -56.46;
                pressure = 22.65 * Math.Exp(1.73 - 0.000157 * altitude);

            }
            if (altitude > 25000)   // upper sratosphere
            {
                temprature = -131.21 + 0.00299 * altitude;
                pressure = 2.488 * Math.Pow(((temprature + 273.1) / 216.6), -11.388);

            }
            density = pressure / (0.2869 * (temprature + 273.1));

            // (Kg/cu m)
            return density;
        }

        public abstract override Vector3 calculate(Vector3 position, Vector3 angle);
    }
}
