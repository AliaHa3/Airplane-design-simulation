using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    abstract class Force
    {
        public Vector3 intensity;
        public Vector3 momentumIntensity;
        public double forceValue;


        public abstract Vector3 calculate(Vector3 position,Vector3 angle);
        public abstract Vector3 angularCalculate(Vector3 position, Vector3 angle);

    }
}
