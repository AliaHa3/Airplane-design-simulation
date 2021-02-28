using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    class Gravity : Force
    {
        private readonly double mass;

        public Gravity(double mass)
        {
            this.mass = mass;
            intensity.X = 0f;  intensity.Z = 0f;
        }


        public override Vector3 calculate(Vector3 position, Vector3 angle)
        {
            intensity.Y = -(float)( 9.8f * mass);
            return intensity;
        }

        public override Vector3 angularCalculate(Vector3 position, Vector3 angle)
        {
            momentumIntensity.X = (position.Y - PLANE.centerOfGravity.Y) * intensity.Z -
                               (position.Z - PLANE.centerOfGravity.Z) * intensity.Y;
            momentumIntensity.Y = (position.Z - PLANE.centerOfGravity.Z) * intensity.X -
                               (position.X - PLANE.centerOfGravity.X) * intensity.Z;
            momentumIntensity.Z = (position.X - PLANE.centerOfGravity.X) * intensity.Y -
                               (position.Y - PLANE.centerOfGravity.Y) * intensity.X;
            return momentumIntensity;
        }
    }
}
