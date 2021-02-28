using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    class Thrust : Force
    {
        public Thrust(double intensity)
        {
            this.forceValue = intensity;
        }

        public override Vector3 calculate(Vector3 position, Vector3 rotation)
        {
            intensity = new Vector3(0,0,(float) forceValue);
            intensity = Vector3.Transform(intensity,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X))*
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y))*
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));

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
